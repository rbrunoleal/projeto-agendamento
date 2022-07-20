using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Context
{
	public class ContextDB : DbContext
	{
        public ContextDB() { }
        public DbSet<Cliente> Clientes { get; set; }        
        public ContextDB(DbContextOptions<ContextDB> options) : base(options) {}
    }   
}
