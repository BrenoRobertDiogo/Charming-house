using System;
using Charming_house.controllers;
using Charming_house.exception;
using Charming_house.utils;
using Charming_house.views;
using Charming_house.models;
using System.Collections.Generic;

namespace Charming_house
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();

            // Para a inicialização do banco de dados.
            SeedCreateData.CreateServicos();
            SeedCreateData.CreatePessoas();

            List<Object> carai = App.Agendar();

            List<Servico> ai = (List<Servico>) carai[0];
            Funcionario func = (Funcionario) carai[1];
            DateTime data = (DateTime) carai[2];

            System.Console.WriteLine(ai[0].NomeServico);
            System.Console.WriteLine(func.Nome);
            System.Console.WriteLine(data);

        }
    }
}
