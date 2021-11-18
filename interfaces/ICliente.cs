using Charming_house.models;
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
        Agendamento agendar(Funcionario funcionario, List<Servico> Servicos);
        bool pagar(double valor);
        bool pagar(double valor, string metodo);

    }
}
