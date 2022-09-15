using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Domain.DTOs
{
    
    public class FuncionarioDto

    {
        public string Nome { get; set; }

        public List<ServicoDto> Servicos { get; set; }
    }
}
