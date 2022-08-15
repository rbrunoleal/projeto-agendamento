using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.ViewModels.Responses
{
        public class AgendamentoResponse
    {
        public ClienteResponse Cliente { get; set; }


        public ServicoResponse Servico { get; set; }

        public FuncionarioResponse Funcionario { get; set; }

        public DateTime HorarioInicio { get; set; }
    }
}
