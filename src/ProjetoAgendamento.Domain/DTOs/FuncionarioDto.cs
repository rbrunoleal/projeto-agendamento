using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Domain.DTOs
{
    
    public class FuncionarioDto 

    {
        public string Descricao { get; set; }

        public List<Servico> Servicos { get; set; }
}
}
