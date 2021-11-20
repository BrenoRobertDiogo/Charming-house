using System;

namespace Charming_house.models
{
    [Serializable]
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        
        public Pessoa(string nome, int idade, string usuario, string senha)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Usuario = usuario;
            this.Senha = senha;
        }
        
        public Pessoa() { }
        
    }
}