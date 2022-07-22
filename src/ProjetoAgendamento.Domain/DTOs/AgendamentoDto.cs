
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Domain.DTOs
{
        public class Agendamento 
    {
        public Cliente Cliente { get; set; }


        public Servico Servico { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime HorarioInicio { get; set; }
    }
}
