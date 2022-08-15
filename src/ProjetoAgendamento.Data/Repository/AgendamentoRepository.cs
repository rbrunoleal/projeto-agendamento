using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{	 
	public class AgendamentoRepository : BaseRepository<Agendamento>, IAgendamentoRepository
	{
		public AgendamentoRepository(ContextDB context) : base(context) { }
	}
}
