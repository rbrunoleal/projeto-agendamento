using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IAgendamentoService
    {
        Task<IEnumerable<AgendamentoResponse>> BuscarTodos();        
        Task<AgendamentoDto> Insere(AgendamentoDto Agenda);
        Task<AgendamentoDto> Atualiza(AgendamentoDto Agenda);
        Task<bool> Deleta(Guid id);
        AgendamentoResponse BuscarAgendamento(Guid id);
    }
}
