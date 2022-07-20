using AutoMapper;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Domain.ProfileMappings
{
    public class EntityToResponse : Profile
    {
        public EntityToResponse() {
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
        }
    }
}
