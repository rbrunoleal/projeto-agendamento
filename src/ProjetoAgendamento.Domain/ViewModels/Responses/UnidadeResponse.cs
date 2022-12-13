using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.ViewModels.Responses
{
	public class UnidadeResponse
	{
		public Guid Id { get; set; }
		public string Descricao { get; set; }
		public EnderecoResponse Endereco { get; set; }
	}
}
