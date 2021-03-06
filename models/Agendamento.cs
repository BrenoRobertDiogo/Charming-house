using System.Collections.Generic;
using System;

namespace Charming_house.models
{
    [Serializable]
    public class Agendamento
    {
        public DateTime DataAgendamento { get; set; }
        public Cliente Cliente { get; set; }
        public List<Servico> Servico { get; set; }
        public Funcionario Funcionario { get; set; }
        public Pagar Pagar { get; set; }

        public Agendamento(DateTime dataAgendamento, Cliente cliente, List<Servico> Servico, Funcionario Funcionario)
        {
            this.DataAgendamento = dataAgendamento;
            this.Cliente = cliente;
            this.Servico = Servico;
            this.Funcionario = Funcionario;
        }

    }
}