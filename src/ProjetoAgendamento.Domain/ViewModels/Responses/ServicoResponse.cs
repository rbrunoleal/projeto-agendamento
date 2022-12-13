namespace ProjetoAgendamento.Domain.ViewModels.Responses
{
    public class ServicoResponse 
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public int Tempo { get; set; }

        public string Titulo { get; set; }
    }
}
