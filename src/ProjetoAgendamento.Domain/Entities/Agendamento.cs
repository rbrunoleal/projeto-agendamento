using System.ComponentModel.DataAnnotations.Schema;

    namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Agendamentos")]

    public class Agendamento : BaseEntity 
    {
        public Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }
        public Servico Servico { get; set; }
        public Guid ServicoId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Guid FuncionarioId { get; set; }
        public Unidade Unidade { get; set; }
        public Guid UnidadeId { get; set; }
        public DateTime HorarioInicio { get; set; }
    }
}
