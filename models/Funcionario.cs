using System.Collections.Generic;

namespace Charming_house.models
{
    public class Funcionario : Pessoa
    {
        public double AnosExperiencia { get; set; }
        public List<Servico> Servicos { get; set; }
        public Funcionario(string nome, int idade, List<Servico> servicos, string usuario, string senha) : base(nome, idade, usuario, senha)
        {
            this.Servicos = servicos;

        }


    }
}