namespace Charming_house.models
{
    public class Servico
    {
        public double ValorServico { get; set; }
        public string NomeServico { get; set; }
        public Servico() { }
        public Servico(double valorServico, string nomeServico)
        {
            this.ValorServico = valorServico;
            this.NomeServico = nomeServico;
        }
    }
}