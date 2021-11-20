using Charming_house.Enum;
using System;


namespace Charming_house.models
{
    [Serializable]
    public class Pagar
    {
        public double Valor { get; set; }
        public Pagamento Metodo { get; set; }

        public Pagar(double valor, Pagamento metodo){
            this.Valor = valor;
            this.Metodo = metodo;
        }
    }
}