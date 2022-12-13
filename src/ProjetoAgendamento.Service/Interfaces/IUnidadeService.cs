using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IUnidadeService
    {
        Task<IEnumerable<UnidadeResponse>> BuscarTodos();
        Task<UnidadeDto> Insere(UnidadeDto Unidade);
        Task<UnidadeDto> Atualiza(UnidadeDto Unidade);
        Task<bool> Deleta(Guid id);
        UnidadeResponse BuscaUnidade(Guid id);
    }
}
