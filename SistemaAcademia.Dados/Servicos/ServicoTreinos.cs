using Microsoft.EntityFrameworkCore;

using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Suporte;

namespace SistemaAcademia.Dados.Servicos
{
    public class ServicoTreinos
    {
        private readonly SistemaAcademiaDbContext dbContext;

        public ServicoTreinos(SistemaAcademiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AtualizarTreinos(long alunoId, IEnumerable<ModeloTreino.Detalhes> treinos)
        {
            var novosTreinos = new List<Treino>();

            foreach (var treino in treinos)
            {
                var novoTreino = new Treino
                {
                    AlunoId = alunoId,
                    NumeroAtualTreino = 0,
                    NumeroMaximoTreino = 40,
                    Tipo = treino.Tipo,
                    Ativo = treino.Ativo,
                    TreinoAtual = false,
                    DataTreino = new()
                };

                foreach (var exercicio in treino.Exercicios)
                {
                    novoTreino.Exercicios.Add(new TreinoExercicio
                    {
                        ExercicioId = exercicio.ExercicioId,
                        NumeroRepeticoes = exercicio.NumeroRepeticoes,
                        NumeroSeries = exercicio.NumeroSeries
                    });
                }

                novosTreinos.Add(novoTreino);

                var treinosAntigos = dbContext.Treinos.Where(treino => treino.AlunoId == alunoId).ToList();

                if (treinosAntigos.Any())
                    dbContext.RemoveRange(treinosAntigos);
            }

            dbContext.AddRange(novosTreinos);
            dbContext.SaveChanges();
        }

        public IEnumerable<ModeloTreino.Item> CriarLista(long alunoId)
        {
            var modelos = dbContext.Treinos
                .AsNoTracking()
                .Where(treino => treino.AlunoId == alunoId)
                .Select(treino => new ModeloTreino.Item
                {
                    Id = treino.Id,
                    Tipo = treino.Tipo
                })
                .ToList();

            foreach (var modelo in modelos)
                modelo.Descricao = SuporteDados.ObterNomeTreinoTipo(modelo.Tipo);

            return modelos;
        }

        public IEnumerable<ModeloTreino.Detalhes> ObterTodosDetalhesPorAlunoId(long alunoId)
        {
            return dbContext.Treinos
                .AsNoTracking()
                .Where(treino => treino.AlunoId == alunoId)
                .Include(treino => treino.Exercicios)
                .ThenInclude(exercicio => exercicio.Exercicio)
                .Select(treino => new ModeloTreino.Detalhes
                {
                    NumeroAtualTreino = treino.NumeroAtualTreino,
                    NumeroMaximoTreino = treino.NumeroMaximoTreino,
                    Tipo = treino.Tipo,
                    Ativo = treino.Ativo,
                    Exercicios = treino.Exercicios.Select(exercicio =>
                    new ModeloTreino.Detalhes.Exercicio
                    {
                        ExercicioId = exercicio.ExercicioId,
                        ExercicioDescricao = exercicio.Exercicio.Descricao,
                        NumeroRepeticoes = exercicio.NumeroRepeticoes,
                        NumeroSeries = exercicio.NumeroSeries,
                    }).ToList()
                })
                .ToList();
        }

        public ModeloTreino.TreinoDetalhes? ObterTreinoDetalhesPorId(long id)
        {
            return dbContext.Treinos
                .AsNoTracking()
                .Where(treino => treino.Id == id)
                .Include(treino => treino.Exercicios)
                .ThenInclude(exercicio => exercicio.Exercicio)
                .Include(treino => treino.Aluno)
                .Select(treino => new ModeloTreino.TreinoDetalhes
                {
                    NomeCompleto = treino.Aluno.NomeCompleto,
                    NumeroAtualTreino = treino.NumeroAtualTreino,
                    NumeroMaximoTreino = treino.NumeroMaximoTreino,
                    Tipo = treino.Tipo,
                    Ativo = treino.Ativo,
                    Exercicios = treino.Exercicios.Select(exercicio =>
                    new ModeloTreino.TreinoDetalhes.Exercicio
                    {
                        ExercicioDescricao = exercicio.Exercicio.Descricao,
                        NumeroRepeticoes = exercicio.NumeroRepeticoes,
                        NumeroSeries = exercicio.NumeroSeries,
                    }).ToList()
                })
                .SingleOrDefault();
        }

        public bool AtualizarTreinoAtual(long alunoId)
        {
            var aluno = dbContext.Alunos
                .FirstOrDefault(aluno => aluno.Id == alunoId);

            if (aluno is null)
                throw new InvalidOperationException();

            var atualizou = false;

            if (aluno.DataUltimoTreino.Date < DateTime.Now.Date)
            {
                var treinos = dbContext.Treinos
                    .Include(treino => treino.Exercicios)
                    .ThenInclude(exercicio => exercicio.Exercicio)
                    .Where(x => x.AlunoId == alunoId && x.Ativo)
                    .ToList();

                var proximoTreino = true;

                for (var i = 0; i < treinos.Count; i++)
                {
                    var treino = treinos.ElementAt(i);

                    if (treino.TreinoAtual)
                    {
                        if (i == treinos.Count - 1)
                        {
                            treino.TreinoAtual = false;

                            var primeiroTreino = treinos.First();

                            primeiroTreino.TreinoAtual = true;
                            primeiroTreino.DataTreino = DateTime.Now;
                            primeiroTreino.NumeroAtualTreino++;

                            aluno.DataUltimoTreino = primeiroTreino.DataTreino;

                            atualizou = true;

                            break;
                        }
                        else
                        {
                            proximoTreino = true;

                            treino.TreinoAtual = false;
                        }
                    }
                    else if (proximoTreino)
                    {
                        proximoTreino = false;

                        treino.TreinoAtual = true;
                        treino.DataTreino = DateTime.Now;
                        treino.NumeroAtualTreino++;

                        aluno.DataUltimoTreino = treino.DataTreino;

                        atualizou = true;

                        break;
                    }
                }

                dbContext.Update(aluno);
                dbContext.UpdateRange(treinos);
                dbContext.SaveChanges();
            }

            return atualizou;
        }
    }
}
