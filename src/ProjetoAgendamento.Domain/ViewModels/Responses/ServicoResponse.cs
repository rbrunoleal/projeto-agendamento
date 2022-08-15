using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.ViewModels.Responses
{
    public class ServicoResponse 
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TimeSpan Tempo { get; set; }

        public string Titulo { get; set; }

        public List<FuncionarioResponse> Funcionario { get; set; }

    }



}
