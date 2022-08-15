using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Service.Interfaces
{
    public interface IFuncionarioService
    {
        Task<IEnumerable<FuncionarioResponse>> BuscarTodos();        
        Task<FuncionarioDto> Insere(FuncionarioDto Funcionario);
        Task<FuncionarioDto> Atualiza(FuncionarioDto Funcionario);
        Task<bool> Deleta(Guid id);
    }
}
