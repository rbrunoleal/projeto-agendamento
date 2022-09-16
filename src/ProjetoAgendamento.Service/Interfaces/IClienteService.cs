using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteResponse>> BuscarTodos();        
        Task<ClienteDto> Insere(ClienteDto Cliente);
        Task<ClienteDto> Atualiza(ClienteDto Cliente);
        Task<bool> Deleta(Guid id);
    }
}
