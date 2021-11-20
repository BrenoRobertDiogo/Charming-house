using System.Collections.Generic;
using Charming_house.interfaces;
using System;

using System;

namespace Charming_house.models
{
    [Serializable]
    public class Cliente : Pessoa, ICliente
    {
        public int Fidelidade { get; set; }
        public Cartao Cartao { get; set; }
        public double Saldo { get; set; }

        public Cliente(string nome, int idade, string usuario, string senha) 
        : base(nome, idade, usuario, senha)
        {
            this.Fidelidade = 0;
            this.Cartao = null;
            this.Saldo = 0.00;
        }

        public Agendamento agendar(Funcionario funcionario, List<Servico> Servicos)
        {
            return new Agendamento();
        }


        /* SOBRESCRITA */
        public bool pagar(double valor)
        {
            return true;
        }
        public bool pagar(double valor, string metodo)
        {
            return true;
        }
        public bool salvarCartao (Cartao cartao)
        {
            if (this.Cartao == null)
            {
                this.Cartao = cartao;
                Console.WriteLine($"Cartão salvo com sucesso!!!");
                return true;
            }
            Console.WriteLine("Já existe um cartão cadastrado.");
            return false;
        }

    }
}
