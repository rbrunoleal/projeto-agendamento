using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.ViewModels.Responses
{
    
    public class FuncionarioResponse 

    {
        public string Nome { get; set; }

        public List<ServicoResponse> Servicos { get; set; }
    }
}
