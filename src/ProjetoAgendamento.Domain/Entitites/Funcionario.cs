using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Funcionrio")]
    public class Funcionario : BaseEntity

    {
        public string Nome { get; set; }

        public List<Servico> Servicos { get; set; }
}
}
