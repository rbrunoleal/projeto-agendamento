using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IHorarioService
    {
        Task<IEnumerable<HorarioResponse>> BuscarTodos();        
        Task<HorarioDto> Insere(HorarioDto Horario);
        Task<HorarioDto> Atualiza(HorarioDto Horario);
        Task<bool> Deleta(Guid id);
    }
}
