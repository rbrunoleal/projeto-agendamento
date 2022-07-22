using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Horarios")]
    public class HorarioDto : BaseEntity
    {
        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }
    }



}
