    using Microsoft.Extensions.DependencyInjection;
using ProjetoAgendamento.Service.Interfaces;
using ProjetoAgendamento.Service.Services;

namespace ProjetoAgendamento.Service.DepedencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IAgendamentoService, AgendamentoService>();            
            serviceCollection.AddTransient<IHorarioService, HorarioService>();
            serviceCollection.AddTransient<IUnidadeService, UnidadeService>();
            serviceCollection.AddTransient<IFuncionarioService, FuncionarioService>();
            serviceCollection.AddTransient<IServicoService, ServicoService>();
        }
    }
}
