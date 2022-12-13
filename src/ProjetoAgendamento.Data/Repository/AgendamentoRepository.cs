using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Data.Repository.RepositoryExtension;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{	 
	public class AgendamentoRepository : BaseRepository<Agendamento>, IAgendamentoRepository
	{
		public AgendamentoRepository(ContextDB context) : base(context) { }

		public Agendamento BuscarAgendamento(string id) {
			return _dataSet.DynamicInclude("Cliente", "Servico", "Funcionario", "Unidade")
				.FirstOrDefault(x => x.Id.ToString().Equals(id));
		}
	}
}
