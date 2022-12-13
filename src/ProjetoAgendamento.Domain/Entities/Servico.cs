using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Servicos")]
    public class Servico : BaseEntity
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public int Tempo { get; set; }

        public string Titulo { get; set; }
        public Unidade Unidade { get; set; }
        public Guid UnidadeId { get; set; }
    }
}
