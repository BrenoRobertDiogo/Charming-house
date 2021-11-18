using System.Collections.Generic;

namespace Charming_house.models
{
    public class Funcionario : Pessoa
    {
        public double AnosExperiencia { get; set; }
        public static List<Servico> Servicos = new List<Servico> {
            new Servico
            {
                NomeServico = "Manicure",
                ValorServico = 50
            },
            new Servico
            {
                NomeServico = "Pedicure",
                ValorServico = 35
            },
            new Servico
            {
                NomeServico = "Maquiagem",
                ValorServico = 15
            },
        };
        public Funcionario(string nome, int idade, List<Servico> servicos, string usuario, string senha) 
        : base(nome, idade, usuario, senha)
        {
            
        }


    }
}