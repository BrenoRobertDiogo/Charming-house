using Charming_house.database;
using Charming_house.models;
using System;
using System.Collections.Generic;

namespace Charming_house.repository
{
    public class PessoaRepository
    {
        private static string database = "pessoa";

        public static List<Pessoa> findAll(){
            List<Pessoa> pessoa = DatabaseController.GetDatabase<Pessoa>(database);
            return pessoa.Count != 0 ? pessoa : null; 
        }

        public static void Save(List<Pessoa> pessoa){
            DatabaseController.SaveDatabase<Pessoa>(pessoa, database);
        }
        
    }
}