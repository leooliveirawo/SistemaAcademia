using FluentValidation;
using FluentValidation.Results;

using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;

using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Suporte;
using SistemaAcademia.Dados.Valores;

using System.Linq;

namespace SistemaAcademia.Dados.Servicos
{
    public class ServicoAlunos
    {
        private readonly SistemaAcademiaDbContext dbContext;

        public ServicoAlunos(SistemaAcademiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private static void AtualizarAluno(ModeloAluno.Detalhes modelo, Aluno aluno)
        {
            aluno.NomeCompleto = modelo.NomeCompleto;
            aluno.CPF = modelo.CPF;
            aluno.PlanoId = modelo.PlanoId;
            aluno.Logradouro = modelo.Logradouro;
            aluno.Complemento = modelo.Complemento;
            aluno.CEP = modelo.CEP;
            aluno.Bairro = modelo.Bairro;
            aluno.Cidade = modelo.Cidade;
            aluno.EstadoUF = modelo.EstadoUF;
            aluno.DataUltimoTreino = new();

            aluno.Treinos.Clear();
        }
        
        private static void AtualizarTelefones(ModeloAluno.Detalhes modelo, Aluno aluno)
        {
            aluno.Telefones.Clear();

            foreach (var telefone in modelo.Telefones)
                aluno.Telefones.Add(new AlunoTelefone
                {
                    DDD = telefone.DDD,
                    Numero = telefone.Numero,
                    Tipo = telefone.Tipo
                });
        }

        public void Criar(ModeloAluno.Detalhes modelo)
        {
            var aluno = new Aluno();

            AtualizarAluno(modelo, aluno);
            AtualizarTelefones(modelo, aluno);

            aluno.Treinos = SuporteDados.PreencherTodosTreinoTipo().ToList();

            dbContext.Add(aluno);
            dbContext.SaveChanges();
        }

        public void Editar(long id, ModeloAluno.Detalhes modelo)
        {
            var aluno = dbContext.Alunos
                .Include(aluno => aluno.Telefones)
                .SingleOrDefault(aluno => aluno.Id == id);

            if (aluno is null)
                throw new InvalidOperationException();

            AtualizarAluno(modelo, aluno);
            AtualizarTelefones(modelo, aluno);

            dbContext.Update(aluno);
            dbContext.SaveChanges();
        }

        public void Excluir(long id)
        {
            var aluno = dbContext.Alunos.SingleOrDefault(aluno => aluno.Id == id);

            if (aluno is null)
                throw new InvalidOperationException();


            dbContext.Remove(aluno);
            dbContext.SaveChanges();
        }

        public ValidationResult Validar(ModeloAluno.Detalhes modelo)
        {
            var validador = new InlineValidator<ModeloAluno.Detalhes>();

            validador.RuleFor(x => x.NomeCompleto)
                .NotEmpty()
                .WithMessage("O nome completo não foi informado.");

            validador.RuleFor(x => x.CPF)
                .NotEmpty()
                .WithMessage("O CPF não foi informado.");

            validador.RuleFor(x => x.Telefones.Count)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Nenhum telefone foi informado.");

            /*
            validador.RuleFor(x => x.Treinos)
                .Custom((treinos, context) =>
                {
                    return;

                    var treinosAtivos = treinos.Where(treino => treino.Ativo).ToList();

                    foreach (var treinoAtivo in treinosAtivos)
                    {
                        if (treinoAtivo.Exercicios.Count == 0)
                        {
                            var treinoTipo = string.Empty;

                            if (treinoAtivo.Tipo == TreinoTipo.TreinoA)
                                treinoTipo = "Treino A";
                            else if (treinoAtivo.Tipo == TreinoTipo.TreinoB)
                                treinoTipo = "Treino B";
                            else if (treinoAtivo.Tipo == TreinoTipo.TreinoC)
                                treinoTipo = "Treino C";
                            else if (treinoAtivo.Tipo == TreinoTipo.TreinoD)
                                treinoTipo = "Treino D";
                            else if (treinoAtivo.Tipo == TreinoTipo.TreinoE)
                                treinoTipo = "Treino E";
                            else if (treinoAtivo.Tipo == TreinoTipo.TreinoF)
                                treinoTipo = "Treino F";

                            context.AddFailure($"{treinoTipo} não contém exercicios");
                        }
                    }
                });
            */
            return validador.Validate(modelo);
        }

        public ModeloAluno.Detalhes? ObterDetalhes(long id)
        {
            return dbContext.Alunos
                .AsNoTracking()
                .Where(aluno => aluno.Id == id)
                .Include(aluno => aluno.Telefones)
                .Include(aluno => aluno.Treinos)
                .ThenInclude(treino => treino.Exercicios)
                .ThenInclude(exercicio => exercicio.Exercicio)
                .Select(aluno => new ModeloAluno.Detalhes
                {
                    PlanoId = aluno.PlanoId,
                    NomeCompleto = aluno.NomeCompleto,
                    CPF = aluno.CPF,
                    DataNascimento = aluno.DataNascimento,
                    Logradouro = aluno.Logradouro,
                    Complemento = aluno.Complemento,
                    CEP = aluno.CEP,
                    Bairro = aluno.Bairro,
                    Cidade = aluno.Cidade,
                    EstadoUF = aluno.EstadoUF,
                    Telefones = aluno.Telefones.Select(telefone => new ModeloAluno.Detalhes.Telefone
                    {
                        Tipo = telefone.Tipo,
                        DDD = telefone.DDD,
                        Numero = telefone.Numero,
                        PossuiWhatsApp = telefone.PossuiWhatsApp
                    }).ToList(),
                })
                .SingleOrDefault();
        }

        public ModeloAluno.Detalhes? ObterDetalhesSomenteNomeCompletoCPF(long id)
        {
            return dbContext.Alunos
                .AsNoTracking()
                .Where(aluno => aluno.Id == id)
                .Select(aluno => new ModeloAluno.Detalhes
                {
                    NomeCompleto = aluno.NomeCompleto,
                    CPF = aluno.CPF,
                })
                .SingleOrDefault();
        }
    }
}
