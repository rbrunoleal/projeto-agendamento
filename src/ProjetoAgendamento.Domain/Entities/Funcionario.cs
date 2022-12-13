using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Funcionarios")]
    public class Funcionario : BaseEntity
    {        
		public string Nome { get; set; }
        public Unidade Unidade { get; set; }
        public Guid UnidadeId { get; set; }

    }
}
