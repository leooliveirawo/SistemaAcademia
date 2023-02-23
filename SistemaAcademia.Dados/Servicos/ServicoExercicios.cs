using Microsoft.EntityFrameworkCore;

using SistemaAcademia.Dados.Modelos;

namespace SistemaAcademia.Dados.Servicos
{
    public class ServicoExercicios
    {
        private readonly SistemaAcademiaDbContext dbContext;

        public ServicoExercicios(SistemaAcademiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ModeloExercicio.Item? ObterItemPorId(long id)
        {
            return dbContext.Exercicios.AsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => new ModeloExercicio.Item
                {
                    Id = x.Id,
                    Descricao = x.Descricao,
                })
                .SingleOrDefault();
        }

        public IEnumerable<ModeloExercicio.Item> CriarLista()
        {
            return dbContext.Exercicios.AsNoTracking()
                .Select(x => new ModeloExercicio.Item
                {
                    Id = x.Id,
                    Descricao = x.Descricao,
                })
                .ToList();
        }
    }
}
