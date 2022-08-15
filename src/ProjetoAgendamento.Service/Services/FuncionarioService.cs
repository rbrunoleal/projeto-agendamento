using AutoMapper;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;
using ProjetoAgendamento.Service.Interfaces;

namespace ProjetoAgendamento.Service.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _repository;
		private readonly IMapper _mapper;

		public FuncionarioService(IFuncionarioRepository repository, IMapper mapper) {
            _repository = repository;
			_mapper = mapper;
		}      

        public async Task<bool> Deleta(Guid id) {
            return await _repository.DeleteAsync(id);
        }

		async Task<IEnumerable<FuncionarioResponse>> IFuncionarioService.BuscarTodos() {
			var listEntity = await _repository.SelectAsync();
			return _mapper.Map<IEnumerable<FuncionarioResponse>>(listEntity);
		}

		public async Task<FuncionarioDto> Insere(FuncionarioDto Funcionario) {
			var dtoEntity = _mapper.Map<Funcionario>(Funcionario);
			var entity = await _repository.InsertAsync(dtoEntity);			
			return _mapper.Map<FuncionarioDto>(entity);
		}

		public async Task<FuncionarioDto> Atualiza(FuncionarioDto Funcionario) {
			var dtoEntity = _mapper.Map<Funcionario>(Funcionario);
			var entity = await _repository.UpdateAsync(dtoEntity);
			return _mapper.Map<FuncionarioDto>(entity);
		}		
	}
}
