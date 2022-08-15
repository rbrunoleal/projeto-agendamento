using AutoMapper;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;
using ProjetoAgendamento.Service.Interfaces;

namespace ProjetoAgendamento.Service.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _repository;
		private readonly IMapper _mapper;

		public ServicoService(IServicoRepository repository, IMapper mapper) {
            _repository = repository;
			_mapper = mapper;
		}      

        public async Task<bool> Deleta(Guid id) {
            return await _repository.DeleteAsync(id);
        }

		async Task<IEnumerable<ServicoResponse>> IServicoService.BuscarTodos() {
			var listEntity = await _repository.SelectAsync();
			return _mapper.Map<IEnumerable<ServicoResponse>>(listEntity);
		}

		public async Task<ServicoDto> Insere(ServicoDto Servico) {
			var dtoEntity = _mapper.Map<Servico>(Servico);
			var entity = await _repository.InsertAsync(dtoEntity);			
			return _mapper.Map<ServicoDto>(entity);
		}

		public async Task<ServicoDto> Atualiza(ServicoDto Servico) {
			var dtoEntity = _mapper.Map<Servico>(Servico);
			var entity = await _repository.UpdateAsync(dtoEntity);
			return _mapper.Map<ServicoDto>(entity);
		}		
	}
}
