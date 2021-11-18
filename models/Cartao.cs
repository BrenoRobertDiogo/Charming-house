using System;
namespace Charming_house.models
{
    public class Cartao
    {
        public string Tipo { get; set; }
        
        public int Numero { get; set; }
        public int CV { get; set; }
        public DateTime DataValidade { get; set; }
    }
}