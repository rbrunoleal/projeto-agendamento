using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.DTOs
{
	public class EnderecoDto
	{
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string CEP { get; set; }
		public string Descricao { get; set; }
		public string Complemento { get; set; }
		public int Numero { get; set; }
	}
}
