using AutoMapper;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;
using ProjetoAgendamento.Service.Interfaces;

namespace ProjetoAgendamento.Service.Services
{
    public class HorarioService : IHorarioService
    {
        private readonly IHorarioRepository _repository;
		private readonly IMapper _mapper;

		public HorarioService(IHorarioRepository repository, IMapper mapper) {
            _repository = repository;
			_mapper = mapper;
		}      

        public async Task<bool> Deleta(Guid id) {
            return await _repository.DeleteAsync(id);
        }

		async Task<IEnumerable<HorarioResponse>> IHorarioService.BuscarTodos() {
			var listEntity = await _repository.SelectAsync();
			return _mapper.Map<IEnumerable<HorarioResponse>>(listEntity);
		}

		public async Task<HorarioDto> Insere(HorarioDto Horario) {
			var dtoEntity = _mapper.Map<Horario>(Horario);
			var entity = await _repository.InsertAsync(dtoEntity);			
			return _mapper.Map<HorarioDto>(entity);
		}

		public async Task<HorarioDto> Atualiza(HorarioDto Horario) {
			var dtoEntity = _mapper.Map<Horario>(Horario);
			var entity = await _repository.UpdateAsync(dtoEntity);
			return _mapper.Map<HorarioDto>(entity);
		}		
	}
}
