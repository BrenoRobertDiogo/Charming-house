using System.Collections.Generic;
using Charming_house.interfaces;

namespace Charming_house.models
{
    public class Cliente : Pessoa, ICliente
    {
        public int Fidelidade { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Cartao Cartao { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public double Saldo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Agendamento agendar(Funcionario funcionario, List<Servico> Servicos)
        {
            throw new System.NotImplementedException();
        }

        public bool pagar(double valor)
        {
            throw new System.NotImplementedException();
        }

        public bool pagar(double valor, string metodo)
        {
            throw new System.NotImplementedException();
        }
    }
}
