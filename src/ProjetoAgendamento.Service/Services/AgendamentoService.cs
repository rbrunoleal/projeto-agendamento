using AutoMapper;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;
using ProjetoAgendamento.Service.Interfaces;

namespace ProjetoAgendamento.Service.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _repository;
		private readonly IMapper _mapper;

		public AgendamentoService(IAgendamentoRepository repository, IMapper mapper) {
            _repository = repository;
			_mapper = mapper;
		}      

        public async Task<bool> Deleta(Guid id) {
            return await _repository.DeleteAsync(id);
        }

		async Task<IEnumerable<AgendamentoResponse>> IAgendamentoService.BuscarTodos() {
			var listEntity = await _repository.SelectAsync();
			return _mapper.Map<IEnumerable<AgendamentoResponse>>(listEntity);
		}

		public async Task<AgendamentoDto> Insere(AgendamentoDto Agendamento) {
			var dtoEntity = _mapper.Map<Agendamento>(Agendamento);
			var entity = await _repository.InsertAsync(dtoEntity);			
			return _mapper.Map<AgendamentoDto>(entity);
		}

		public async Task<AgendamentoDto> Atualiza(AgendamentoDto Agendamento) {
			var dtoEntity = _mapper.Map<Agendamento>(Agendamento);
			var entity = await _repository.UpdateAsync(dtoEntity);
			return _mapper.Map<AgendamentoDto>(entity);
		}		
	}
}
