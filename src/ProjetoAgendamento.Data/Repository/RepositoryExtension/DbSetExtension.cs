using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAgendamento.Data.Repository.RepositoryExtension
{
    public static class DbSetExtension
    {
        public static IQueryable<T> DynamicInclude<T>(this DbSet<T> dbSet, params string[] props) where T : class
        {
            var propriedades = typeof(T).GetProperties();
            var query = dbSet.AsQueryable();
            for (int i = 0; i < props.Length; i++)
            {
                if (propriedades.Any(x => x.Name == props[i]))
                    query = query.Include(props[i]);
            }
            return query;
        }
    }
}
