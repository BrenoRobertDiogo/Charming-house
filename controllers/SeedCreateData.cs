using System.Collections.Generic;
using Charming_house.models;
using System.Threading;
using Charming_house.utils;
using Charming_house.repository;
using System;

namespace Charming_house.controllers
{
    public class SeedCreateData
    {
        public static void CreateServicos(){
            List<Servico> servico = ServicoRepository.findAll();
            if(servico == null){
                Logger.Debug("Seed Database Servicos...");
                Thread.Sleep(1000);
                ServicoRepository.Save( seedServicos() );
            }
        }

        public static void CreatePessoas(){
            List<Pessoa> pessoa = PessoaRepository.findAll();
            if(pessoa == null){
                Logger.Debug("Seed Database Pessoas...");
                Thread.Sleep(1000);
                PessoaRepository.Save( seedPessoas() );
            }
        }

        public static void CreateAgendamentos(){
            List<Agendamento> agendamento = AgendamentoRepository.findAll();
            if(agendamento == null){
                Logger.Debug("Seed Database Agendamentos...");
                Thread.Sleep(1000);
                AgendamentoRepository.Save( seedAgendamentos() );
            }
        }

        public static List<Servico> seedServicos(){
            return new List<Servico> {
                new Servico { NomeServico = "Manicure"     , ValorServico = 50   },
                new Servico { NomeServico = "Pedicure"     , ValorServico = 35   },
                new Servico { NomeServico = "Cabelo"       , ValorServico = 100  },
                new Servico { NomeServico = "Barba"        , ValorServico = 10   },
                new Servico { NomeServico = "Sombrancelha" , ValorServico = 50   },
                new Servico { NomeServico = "Depilação"    , ValorServico = 150  },
            };
        }   

        public static List<Pessoa> seedPessoas(){

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add( new Cliente( "Breno O Brabo", 19, "breno" , Password.Encript("12345") ) );
            pessoas.Add( new Cliente( "Arthur RD"    , 22, "thuzin", Password.Encript("12345") ) );
            pessoas.Add( new Cliente( "Matue Caige"  , 23, "matue" , Password.Encript("12345") ) );
            pessoas.Add( new Cliente( "Admin Senior" , 50, "admin" , Password.Encript("12345") ) );

            pessoas.Add( new Funcionario( "Funcionario 1", 18, "func1" , Password.Encript("12345"), 25 ) );
            pessoas.Add( new Funcionario( "Funcionario 2", 20, "func2" , Password.Encript("12345"), 25 ) );
            pessoas.Add( new Funcionario( "Funcionario 3", 22, "func3" , Password.Encript("12345"), 25 ) );

            return pessoas;
        }

        public static List<Agendamento> seedAgendamentos(){

            List<Agendamento> agendamentos = new List<Agendamento>();

            agendamentos.Add( new Agendamento( 
                new DateTime(2022, 1, 12),  
                new Cliente( "Breno O Brabo", 19, "breno" , Password.Encript("12345") ),
                new List<Servico> {
                    new Servico { NomeServico = "Manicure"     , ValorServico = 50   },
                    new Servico { NomeServico = "Pedicure"     , ValorServico = 35   },
                    new Servico { NomeServico = "Cabelo"       , ValorServico = 100  },
                },
                new Funcionario( "Funcionario 1", 18, "func1" , Password.Encript("12345"), 25 )
                )
            );

            agendamentos.Add( new Agendamento( 
                new DateTime(2022, 1, 20),  
                new Cliente( "Breno O Brabo", 19, "breno" , Password.Encript("12345") ),
                new List<Servico> {
                    new Servico { NomeServico = "Barba"        , ValorServico = 10   },
                    new Servico { NomeServico = "Sombrancelha" , ValorServico = 50   },
                    new Servico { NomeServico = "Depilação"    , ValorServico = 150  },
                },
                new Funcionario( "Funcionario 2", 20, "func2" , Password.Encript("12345"), 25 )
                )
            );

            agendamentos.Add( new Agendamento( 
                new DateTime(2022, 1, 20),  
                new Cliente( "Arthur RD"    , 22, "thuzin", Password.Encript("12345") ),
                new List<Servico> {
                    new Servico { NomeServico = "Cabelo"       , ValorServico = 100  },
                    new Servico { NomeServico = "Barba"        , ValorServico = 10   },
                },
                new Funcionario( "Funcionario 3", 22, "func3" , Password.Encript("12345"), 25 )
                )
            );

            return agendamentos;
        }

    }
}