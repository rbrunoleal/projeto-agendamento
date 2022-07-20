using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.ViewModels.Responses
{    
    public class ClienteResponse
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
