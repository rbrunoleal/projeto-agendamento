using ProjetoAgendamento.Domain.Enums;

namespace ProjetoAgendamento.Domain.ViewModels.Responses
{
    
    public class HorarioResponse 
    {
        public DiaDaSemanaEnum DiaDaSemana { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime PausaInicio { get; set; }
        public DateTime PausaFim { get; set; }
        public DateTime? Data { get; set; }
    }
}
