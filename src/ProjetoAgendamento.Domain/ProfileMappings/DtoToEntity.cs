using AutoMapper;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Domain.ProfileMappings
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity() {
            CreateMap<AgendamentoDto, Agendamento>().ReverseMap();
            CreateMap<ClienteDto, Cliente>().ReverseMap();
            CreateMap<FuncionarioDto, Funcionario>().ReverseMap();
            CreateMap<HorarioDto, Horario>().ReverseMap();
            CreateMap<ClienteDto, Cliente>().ReverseMap();
            CreateMap<UnidadeDto, Unidade>().ReverseMap();
            CreateMap<EnderecoDto, Endereco>().ReverseMap();
            CreateMap<ServicoDto, Servico>().ReverseMap();            
        }
    }
}
