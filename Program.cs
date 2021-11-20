using System;
using Charming_house.controllers;
using Charming_house.utils;

namespace Charming_house
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Para a inicialização do banco de dados.
            SeedCreateData.CreateServicos();
            SeedCreateData.CreatePessoas();
            
        }
    }
}
