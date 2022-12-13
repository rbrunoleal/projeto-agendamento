using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Data.Repository.RepositoryExtension;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{
    public class UnidadeRepository : BaseRepository<Unidade>, IUnidadeRepository
    {
        public UnidadeRepository(ContextDB context) : base(context) { }

        public Unidade BuscarUnidade(string id) {
            return _dataSet.DynamicInclude("Endereco")
				.FirstOrDefault(x => x.Id.ToString().Equals(id));            
        }        
    }    
}
