using System.Collections.Generic;
using Charming_house.models;

namespace Charming_house.controllers
{
    public class Cast
    {
        public static Funcionario GetFuncionario(Pessoa pessoa){
            return ( pessoa as Funcionario );
        }

        public static Cliente GetCliente(Pessoa pessoa){
            return ( pessoa as Cliente );
        }

        public static List<Funcionario> GetListFuncionario(List<Pessoa> pessoas){
            List<Funcionario> funcs = new List<Funcionario>();
            foreach (Pessoa item in pessoas)
            {   
                Funcionario func = Cast.GetFuncionario(item);
                if( func != null ){
                    funcs.Add((Funcionario) item);
                }
            }
            return funcs;
        }

    }
}