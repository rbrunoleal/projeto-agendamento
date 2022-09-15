using AutoMapper;
using ProjetoAgendamento.Domain.Entitites;
using ProjetoAgendamento.Domain.ViewModels.Responses;

namespace ProjetoAgendamento.Domain.ProfileMappings
{
    public class EntityToResponse : Profile
    {
        public EntityToResponse() {
            CreateMap<Agendamento, AgendamentoResponse>().ReverseMap();
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
            CreateMap<Funcionario, FuncionarioResponse>().ReverseMap();
            CreateMap<Horario, HorarioResponse>().ReverseMap();
            CreateMap<Servico, ServicoResponse>().ReverseMap();
        }
    }
}
