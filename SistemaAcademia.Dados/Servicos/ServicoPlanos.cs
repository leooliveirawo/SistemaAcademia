using Microsoft.EntityFrameworkCore;

using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Modelos;

namespace SistemaAcademia.Dados.Servicos
{
    public class ServicoPlanos
    {
        private readonly SistemaAcademiaDbContext dbContext;

        public ServicoPlanos(SistemaAcademiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private static void AtualizarPlano(ModeloPlano.Detalhes modelo, Plano plano)
        {
            plano.Descricao = modelo.Descricao;
            plano.CobradoMensalmente = modelo.CobradoMensalmente;
            plano.MesesCobrados = modelo.MesesCobrados;
            plano.Valor = modelo.Valor;
            plano.Dias = modelo.Dias;
        }

        public void Criar(ModeloPlano.Detalhes modelo)
        {
            var plano = new Plano();

            AtualizarPlano(modelo, plano);

            dbContext.Add(plano);
            dbContext.SaveChanges();
        }

        public void Editar(long id, ModeloPlano.Detalhes modelo)
        {
            var plano = dbContext.Planos.SingleOrDefault(plano => plano.Id == id);

            if (plano is null)
                throw new InvalidOperationException();

            AtualizarPlano(modelo, plano);

            dbContext.Update(plano);
            dbContext.SaveChanges();
        }

        public void Excluir(long id)
        {

            var plano = dbContext.Planos.SingleOrDefault(plano => plano.Id == id);

            if (plano is null)
                throw new InvalidOperationException();

            dbContext.Remove(plano);
            dbContext.SaveChanges();
        }

        public IEnumerable<ModeloPlano.Item> CriarLista()
        {
            return dbContext.Planos.AsNoTracking()
                .Select(plano
                => new ModeloPlano.Item
                {
                    Id = plano.Id,
                    Descricao = plano.Descricao,
                })
                .ToList();
        } 

        public IEnumerable<ModeloPlano.Consulta> ListarTudo()
        {
            return dbContext.Planos
                .AsNoTracking()
                .Select(plano => new ModeloPlano.Consulta
                {
                    Id = plano.Id,
                    Descricao = plano.Descricao,
                    Valor = plano.Valor
                });
        }

        public ModeloPlano.Detalhes? ObterDetalhes(long id)
        {
            return dbContext.Planos
                .AsNoTracking()
                .Where(plano => plano.Id == id)
                .Select(plano => new ModeloPlano.Detalhes
                {
                    Descricao = plano.Descricao,
                    Dias = plano.Dias,
                    Valor = plano.Valor,
                    CobradoMensalmente = plano.CobradoMensalmente,
                    MesesCobrados = plano.MesesCobrados
                })
                .SingleOrDefault();
        }
    }
}
