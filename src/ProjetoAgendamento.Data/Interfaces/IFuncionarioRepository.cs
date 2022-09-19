using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Interfaces
{
	public interface IFuncionarioRepository
	{
        Task<Funcionario> InsertAsync(Funcionario item);
        Task<Funcionario> UpdateAsync(Funcionario item);
        Task<bool> DeleteAsync(Guid id);
        Task<Funcionario> SelectAsync(Guid id);
        Task<IEnumerable<Funcionario>> SelectAsync();
        Task<bool> ExistAsync(Guid id);
    }
}
