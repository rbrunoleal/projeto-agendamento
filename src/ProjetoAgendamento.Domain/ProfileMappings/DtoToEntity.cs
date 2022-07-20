using AutoMapper;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Domain.ProfileMappings
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity() {
            CreateMap<ClienteDto, Cliente>().ReverseMap();
        }
    }
}
