using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Interfaces
{
	public interface IServicoRepository 
	{
        Task<Servico> InsertAsync(Servico item);
        Task<Servico> UpdateAsync(Servico item);
        Task<bool> DeleteAsync(Guid id);
        Task<Servico> SelectAsync(Guid id);
        Task<IEnumerable<Servico>> SelectAsync();
        Task<bool> ExistAsync(Guid id);
    }
}
