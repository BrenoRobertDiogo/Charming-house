using Charming_house.models;
using Charming_house.Enum;
using System;
using System.Collections.Generic;

namespace Charming_house.interfaces
{
    public interface ICliente
    {
        /* Variáreis */
        // Fidelidade chegar em certo tamanho ele ganha uma promoção
        int Fidelidade { get; set; }
        Cartao Cartao { get; set; }
        double Saldo { get; set; }

        /* Métodos */
        Agendamento agendar(Funcionario funcionario, List<Servico> servicos, DateTime data);
        Pagar pagar(double valor);
        Pagar pagar(double valor, Pagamento metodo);

    }
}
