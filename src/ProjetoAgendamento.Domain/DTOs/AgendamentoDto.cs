

namespace ProjetoAgendamento.Domain.DTOs
{
        public class AgendamentoDto
    {
        public ClienteDto Cliente { get; set; }


        public ServicoDto Servico { get; set; }

        public FuncionarioDto Funcionario { get; set; }

        public DateTime HorarioInicio { get; set; }
    }
}
