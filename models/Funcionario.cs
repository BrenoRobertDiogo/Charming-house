using System.Collections.Generic;
using System;

namespace Charming_house.models
{
    
    [Serializable]
    public class Funcionario : Pessoa
    {
        public double AnosExperiencia { get; set; }

        public Funcionario(string nome, int idade, string usuario, string senha, double anosExperiencia) 
        : base(nome, idade, usuario, senha)
        {
            this.AnosExperiencia = anosExperiencia;
        }

    }
}