using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
	[Table("Clientes")]	

	public class Cliente : BaseEntity
	{
		public string Cpf { get; set; }
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
	}
}
