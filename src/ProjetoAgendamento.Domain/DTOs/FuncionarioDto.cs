using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Domain.DTOs
{
    
    public class FuncionarioDto : BaseDto

    {
        public string Descricao { get; set; }

        public List<Servico> Servicos { get; set; }
}
}
