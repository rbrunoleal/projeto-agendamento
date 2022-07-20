using AutoMapper;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;
using ProjetoAgendamento.Service.Interfaces;

namespace ProjetoAgendamento.Service.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
		private readonly IMapper _mapper;

		public ClienteService(IClienteRepository repository, IMapper mapper) {
            _repository = repository;
			_mapper = mapper;
		}      

        public async Task<bool> Deleta(Guid id) {
            return await _repository.DeleteAsync(id);
        }

		async Task<IEnumerable<ClienteResponse>> IClienteService.BuscarTodos() {
			var listEntity = await _repository.SelectAsync();
			return _mapper.Map<IEnumerable<ClienteResponse>>(listEntity);
		}

		public async Task<ClienteDto> Insere(ClienteDto Morador) {
			var dtoEntity = _mapper.Map<Cliente>(Morador);
			var entity = await _repository.InsertAsync(dtoEntity);			
			return _mapper.Map<ClienteDto>(entity);
		}

		public async Task<ClienteDto> Atualiza(ClienteDto Morador) {
			var dtoEntity = _mapper.Map<Cliente>(Morador);
			var entity = await _repository.UpdateAsync(dtoEntity);
			return _mapper.Map<ClienteDto>(entity);
		}		
	}
}
