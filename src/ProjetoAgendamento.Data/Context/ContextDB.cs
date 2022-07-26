using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Context
{
	public class ContextDB : DbContext
	{
        public ContextDB() { }
        public DbSet<Cliente> Clientes { get; set; }        
        public ContextDB(DbContextOptions<ContextDB> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: This is messy, but needed for migrations.
            // See https://github.com/aspnet/EntityFramework/issues/639
           
                optionsBuilder.UseNpgsql("<Your Connection String Here>");
          
        }
    }   
}
