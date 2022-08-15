using System.ComponentModel.DataAnnotations.Schema;

    namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Agendamentos")]

    public class Agendamento : BaseEntity 
    {
        public Cliente Cliente { get; set; }


        public Servico Servico { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime HorarioInicio { get; set; }
    }
}
