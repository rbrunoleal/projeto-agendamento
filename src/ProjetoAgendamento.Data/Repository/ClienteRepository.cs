using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{	 
	public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
	{
		public ClienteRepository(ContextDB context) : base(context) { }
	}
}
