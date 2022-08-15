using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IServicoService
    {
        Task<IEnumerable<ServicoResponse>> BuscarTodos();        
        Task<ServicoDto> Insere(ServicoDto Servico);
        Task<ServicoDto> Atualiza(ServicoDto Servico);
        Task<bool> Deleta(Guid id);
    }
}
