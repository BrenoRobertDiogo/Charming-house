using System.Collections.Generic;
using Charming_house.interfaces;
using System;

namespace Charming_house.models
{
    public class Cliente : Pessoa, ICliente
    {
        public int Fidelidade { get; set; }
        public Cartao Cartao { get; set; }
        public double Saldo { get; set; }

        public Agendamento agendar(Funcionario funcionario, List<Servico> Servicos)
        {
            /* Vai verificar se o funcionário tem horário livre naquele momento */
            funcionario.
        }


        /* SOBRESCRITA */
        public bool pagar(double valor)
        {
            
        }
        public bool pagar(double valor, string metodo)
        {
            

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
