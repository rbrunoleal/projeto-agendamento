using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Context
{
	public class ContextDB : DbContext
	{
        public ContextDB() { }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public ContextDB(DbContextOptions<ContextDB> options) : base(options) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }   
}
