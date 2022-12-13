using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
	[Table("Unidades")]
	public class Unidade : BaseEntity
	{
		public string Descricao { get; set; }
		public Endereco Endereco { get; set; }
	}
}
