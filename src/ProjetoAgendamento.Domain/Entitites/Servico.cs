using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Servicos")]
    public class Servico : BaseEntity
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TimeSpan Tempo { get; set; }

        public string Titulo { get; set; }

        public List<Funcionario> Funcionario { get; set; }
    }
}
