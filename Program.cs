using System;
using Charming_house.controllers;
using Charming_house.exception;
using Charming_house.utils;
using Charming_house.views;
using Charming_house.models;
using System.Collections.Generic;
using Charming_house.repository;

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
            SeedCreateData.CreateAgendamentos();

            Cliente cliente = (Cliente) Autenticacao.autentica("breno", "12345");

            App.VerAgendamento(cliente);

        }
    }
}
