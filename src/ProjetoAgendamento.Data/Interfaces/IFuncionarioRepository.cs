using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Interfaces
{
	public interface IUnidadeRepository : IRepository<Unidade>
    {
        Unidade BuscarUnidade(string id);
    }
}
