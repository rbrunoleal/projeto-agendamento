namespace ProjetoAgendamento.Domain.DTOs
{
    public class ServicoDto
    {
        public Guid UnidadeId { get; set; }
        public string? Descricao { get; set; }

        public decimal? Valor { get; set; }

        public decimal? Tempo { get; set; }

        public string? Titulo { get; set; }
    }
}
