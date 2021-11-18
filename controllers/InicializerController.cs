using System.Collections.Generic;
using Charming_house.models;

namespace Charming_house.controllers
{
    public static class InicializerController
    {
        public static List<Servico> CriaServicos()
        {
            return new List<Servico> {
                new Servico
                {
                    NomeServico = "Manicure",
                    ValorServico = 50
                },
                new Servico
                {
                    NomeServico = "Pedicure",
                    ValorServico = 35
                },
                new Servico
                {
                    NomeServico = "Maquiagem",
                    ValorServico = 15
                },
            };
        }
    }
}
