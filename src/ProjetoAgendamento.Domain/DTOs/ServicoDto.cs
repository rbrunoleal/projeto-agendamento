
//dependencias externas
using ProjetoAgendamento.Domain.Entitites;

//local onde fica as classes
namespace ProjetoAgendamento.Domain.DTOs
{
    public class ServicoDto 
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TimeSpan Tempo { get; set; }

        public string Titulo { get; set; }

        public List<Funcionario> Funcionario { get; set; }

    }



}
