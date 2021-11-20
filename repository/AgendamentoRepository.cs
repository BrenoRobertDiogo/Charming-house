using System.Collections.Generic;
using Charming_house.database;
using Charming_house.models;

namespace Charming_house.repository
{
    public class AgendamentoRepository
    {
        private static string database = "agendamento";

        public static List<Agendamento> findAll(){
            List<Agendamento> agendamento = DatabaseController.GetDatabase<Agendamento>(database);
            return agendamento.Count != 0 ? agendamento : null; 
        }

        public static void Save(List<Agendamento> agendamento){
            DatabaseController.SaveDatabase<Agendamento>(agendamento, database);
        }
    }
}