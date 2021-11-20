using System.Linq;
using System.Collections.Generic;
using System;
using Charming_house.models;
using Charming_house.database;

namespace Charming_house.repository
{


    public class ServicoRepository
    {
        private static string database = "servico";

        public static List<Servico> findAll(){
            List<Servico> servico = DatabaseController.GetDatabase<Servico>(database);
            return servico.Count != 0 ? servico : null; 
        }

        public static void Save(List<Servico> servico){
            DatabaseController.SaveDatabase<Servico>(servico, database);
        }
        
    }
}