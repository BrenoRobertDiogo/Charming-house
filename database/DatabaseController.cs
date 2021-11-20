using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Charming_house.database
{
    public static class  DatabaseController
    {   
        private static string PATH = Path.Combine( Path.GetFullPath("."), "database", "db");
        public static void SaveDatabase<T>( this List<T> objeto, string tabela){
            FileStream arq = new FileStream( Path.Combine(PATH, tabela) + ".txt", FileMode.Create);
            BinaryFormatter serial = new BinaryFormatter();
            serial.Serialize(arq, objeto);
            arq.Close();
        }

        public static List<T> GetDatabase<T>(string tabela){
            List<T> info = new List<T>();
            try
            {
                FileStream arq = new FileStream( Path.Combine(PATH, tabela) + ".txt", FileMode.Open);
                if( arq.Length == 0 ){
                    return info;
                }
                BinaryFormatter serial = new BinaryFormatter();
                info = (List<T>) serial.Deserialize(arq);
                arq.Close();
            }
            catch (System.Exception)
            {
                return info;
            }
            return info;
        }
    }
}