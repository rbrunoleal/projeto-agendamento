using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
	[Table("Enderecos")]
	public class Endereco : BaseEntity
	{
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string CEP { get; set; }
		public string Descricao { get; set; }
		public string Complemento { get; set; }
		public int Numero { get; set; }
	}
}
