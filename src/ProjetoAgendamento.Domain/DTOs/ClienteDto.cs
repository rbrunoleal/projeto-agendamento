﻿namespace ProjetoAgendamento.Domain.DTOs
{
    public class ClienteDto 
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cpf {get; set; }
    }
}
