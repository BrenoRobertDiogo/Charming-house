using System.Collections.Generic;
using Charming_house.interfaces;
using System;
using Charming_house.Enum;

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

        public Agendamento agendar(Funcionario funcionario, List<Servico> servicos, DateTime data)
        {
            return new Agendamento(data, this, servicos, funcionario);
        }

        /* SOBRESCRITA */
        public Pagar pagar(double valor)
        {
            return new Pagar(valor, Pagamento.DINHEIRO);
        }

        public Pagar pagar(double valor, Pagamento metodo)
        {
            return new Pagar(valor, metodo);
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
