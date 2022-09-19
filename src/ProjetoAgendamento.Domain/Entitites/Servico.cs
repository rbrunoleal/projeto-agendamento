using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Servicos")]
    public class Servico
    {
        [Key]
        public Guid ServicoId { get; set; }

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

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TimeSpan Tempo { get; set; }

        public string Titulo { get; set; }

        public ICollection<FuncionarioServico> FuncionarioServico { get; set; }
    }
}
