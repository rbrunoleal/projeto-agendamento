using AutoMapper;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;
using ProjetoAgendamento.Service.Interfaces;

namespace ProjetoAgendamento.Service.Services
{
    public class UnidadeService : IUnidadeService
    {
        private readonly IUnidadeRepository _repository;
		private readonly IMapper _mapper;

		public UnidadeService(IUnidadeRepository repository, IMapper mapper) {
            _repository = repository;
			_mapper = mapper;
		}      

        public async Task<bool> Deleta(Guid id) {
            return await _repository.DeleteAsync(id);
        }

		public UnidadeResponse BuscaUnidade(Guid id) {
			var entity =  _repository.BuscarUnidade(id.ToString());
			return _mapper.Map<UnidadeResponse>(entity);
		}

		async Task<IEnumerable<UnidadeResponse>> IUnidadeService.BuscarTodos() {
			var listEntity = await _repository.SelectAsync();
			return _mapper.Map<IEnumerable<UnidadeResponse>>(listEntity);
		}

		public async Task<UnidadeDto> Insere(UnidadeDto Unidade) {
			var dtoEntity = _mapper.Map<Unidade>(Unidade);
			var entity = await _repository.InsertAsync(dtoEntity);			
			return _mapper.Map<UnidadeDto>(entity);
		}	

		public async Task<UnidadeDto> Atualiza(UnidadeDto Unidade) {
			var dtoEntity = _mapper.Map<Unidade>(Unidade);
			var entity = await _repository.UpdateAsync(dtoEntity);
			return _mapper.Map<UnidadeDto>(entity);
		}		
	}
}
