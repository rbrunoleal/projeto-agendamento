using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteResponse>> BuscarTodos();        
        Task<ClienteDto> Insere(ClienteDto Morador);
        Task<ClienteDto> Atualiza(ClienteDto Morador);
        Task<bool> Deleta(Guid id);
    }
}
