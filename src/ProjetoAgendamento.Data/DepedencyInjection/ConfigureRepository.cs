using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Data.Repository;

namespace ProjetoAgendamento.Data.DepedencyInjection
{
	public class ConfigureRepository
	{
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection) {
            serviceCollection.AddDbContext<ContextDB>(
                op => op.UseNpgsql("Host=bue2k5wsjbit9ysot7rz-postgresql.services.clever-cloud.com;Port=5432;Pooling=true;Database=bue2k5wsjbit9ysot7rz;User Id=uldaodjdqpozkroreykg;Password=ti91dGh9u24epzYG46cO;")
            );            

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped(typeof(IAgendamentoRepository), typeof(AgendamentoRepository));
            serviceCollection.AddScoped(typeof(IClienteRepository), typeof(ClienteRepository));
            serviceCollection.AddScoped(typeof(IFuncionarioRepository), typeof(FuncionarioRepository));
            serviceCollection.AddScoped(typeof(IHorarioRepository), typeof(HorarioRepository));
            serviceCollection.AddScoped(typeof(IServicoRepository), typeof(ServicoRepository));
            serviceCollection.AddScoped(typeof(IUnidadeRepository), typeof(UnidadeRepository));
        }
    }
}
