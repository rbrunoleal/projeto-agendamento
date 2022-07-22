﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Domain.Entitites
{
    [Table("Funcionrio")]
    public class Funcionario : BaseEntity

    {
        public string Descricao { get; set; }

        public List<Servico> Servicos { get; set; }
}
}
