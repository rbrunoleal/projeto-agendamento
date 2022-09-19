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
        public DbSet<FuncionarioServico> FuncionarioServico { get; set; }

        public ContextDB(DbContextOptions<ContextDB> options) : base(options) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<FuncionarioServico>()
            .HasKey(bc => new { bc.FuncionarioId, bc.ServicoId });
                modelBuilder.Entity<FuncionarioServico>()
                    .HasOne(bc => bc.Funcionario)
                    .WithMany(b => b.FuncionarioServico)
                    .HasForeignKey(bc => bc.FuncionarioId);
                modelBuilder.Entity<FuncionarioServico>()
                    .HasOne(bc => bc.Servico)
                    .WithMany(c => c.FuncionarioServico)
                    .HasForeignKey(bc => bc.ServicoId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=bue2k5wsjbit9ysot7rz-postgresql.services.clever-cloud.com;Port=5432;Pooling=true;Database=bue2k5wsjbit9ysot7rz;User Id=uldaodjdqpozkroreykg;Password=ti91dGh9u24epzYG46cO;");
        }        
    }   
}
