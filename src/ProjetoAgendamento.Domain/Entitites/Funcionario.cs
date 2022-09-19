using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Funcionarios")]
    public class Funcionario

    {
        [Key]
        public Guid FuncionarioId { get; set; }

		private DateTime? _createAt;

		public DateTime? CreateAt {
			get { return _createAt; }
			set { _createAt = value == null ? DateTime.UtcNow : value; }
		}

		private DateTime? _updateAt;

		public DateTime? UpdateAt {
			get { return _updateAt; }
			set { _updateAt = value == null ? DateTime.UtcNow : value; }
		}

		public string Nome { get; set; }

        public ICollection<FuncionarioServico> FuncionarioServico { get; set; }
    }
}
