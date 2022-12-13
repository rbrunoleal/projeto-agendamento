using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Interfaces
{
	public interface IAgendamentoRepository : IRepository<Agendamento>
	{
		Agendamento BuscarAgendamento(string id);
	}
}
