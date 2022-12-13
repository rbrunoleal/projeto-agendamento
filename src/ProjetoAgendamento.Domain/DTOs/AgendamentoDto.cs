

namespace ProjetoAgendamento.Domain.DTOs
{
    public class AgendamentoDto
    {
        public ClienteDto Cliente { get; set; }
        public Guid ServicoId { get; set; }        
        public Guid FuncionarioId { get; set; }        
        public Guid UnidadeId { get; set; }
        public DateTime HorarioInicio { get; set; }
    }
}
