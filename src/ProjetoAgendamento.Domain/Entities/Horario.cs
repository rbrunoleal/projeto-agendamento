using ProjetoAgendamento.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Horarios")]
    public class Horario: BaseEntity
    {        
        public DiaDaSemanaEnum DiaDaSemana { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime PausaInicio { get; set; }
        public DateTime PausaFim { get; set; }
        public DateTime? Data { get; set; }
    }
}
