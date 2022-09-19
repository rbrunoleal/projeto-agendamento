using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoAgendamento.Domain.Entitites
{
	[Table("FuncionarioServico")]
	public class FuncionarioServico
	{
		public Guid FuncionarioId { get; set; }
		public Funcionario Funcionario { get; set; }
		public Guid ServicoId { get; set; }
		public Servico Servico { get; set; }
	}
}	
