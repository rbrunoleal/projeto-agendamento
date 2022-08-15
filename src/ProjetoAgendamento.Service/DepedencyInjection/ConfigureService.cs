    using Microsoft.Extensions.DependencyInjection;
using ProjetoAgendamento.Service.Interfaces;
using ProjetoAgendamento.Service.Services;

namespace ProjetoAgendamento.Service.DepedencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IAgendamentoService, AgendamentoService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IFuncionarioService, FuncionarioService>();
            serviceCollection.AddTransient<IHorarioService, HorarioService>();
            serviceCollection.AddTransient<IServicoService, ServicoService>();

        }


    }
}
