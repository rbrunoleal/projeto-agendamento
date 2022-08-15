using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{	 
	public class HorarioRepository : BaseRepository<Horario>, IHorarioRepository
	{
		public HorarioRepository(ContextDB context) : base(context) { }
	}
}
