using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Funcionarios")]
    public class Funcionario : BaseEntity

    {
        public string Nome { get; set; }

        public List<Servico> Servicos { get; set; }
}
}
