using System;
using System.Threading;
using Charming_house.utils;
using Charming_house.repository;
using Charming_house.models;
using System.Collections.Generic;
using Charming_house.controllers;

namespace Charming_house.views
{
    public class App
    {
        public static void Menu(){
            Console.Clear();
            Table.PrintLine();
            Table.PrintRow("##### Bem Vindo #####");
            Table.PrintLine();
            Table.PrintRow("1","Entrar");
            Table.PrintRow("2","Cadastrar");
            Table.PrintRow("0","Sair");
            Table.PrintLine();
        }
        
        public static int EscolhaEntrada(){
            Menu();
            int opx = int.Parse(Console.ReadLine());
            if(opx >= 0 && opx <=2){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                Thread.Sleep(1500);
                return EscolhaEntrada();
            }
        }

        public static void MenuPrograma(){
            Console.Clear();
            Table.PrintLine();
            Table.PrintRow("##### Area do Cliente #####");
            Table.PrintLine();
            Table.PrintRow("1","Agendar");
            Table.PrintRow("2","Ver Agendamentos");
            Table.PrintRow("0","Sair");
            Table.PrintLine();
        }

        public static int EscolhaPrograma(){
            MenuPrograma();
            int opx = int.Parse(Console.ReadLine());
            if(opx >= 0 && opx <=2){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                Thread.Sleep(1500);
                return EscolhaPrograma();
            }
        }

        public static int MenuServico(){
            Console.Clear();
            List<Servico> servicos = ServicoRepository.findAll();
            Table.PrintLine();
            Table.PrintRow("##### Serviços Disponiveis #####");
            Table.PrintLine();
            Table.PrintRow("ID", "SERVIÇO","VALOR");
            Table.PrintLine();
            int conta = 1;
            foreach (Servico item in servicos)
            {
                Table.PrintRow( conta.ToString() ,item.NomeServico , item.ValorServico.ToString() );
                conta++;
            }
            Table.PrintLine();
            return servicos.Count;
        }

        public static int EscolhaServico(){
            int quantidade = MenuServico();
            int opx = int.Parse(Console.ReadLine());
            if( opx >= 1 && opx < quantidade + 1 ){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                Thread.Sleep(1500);
                return EscolhaServico();
            }
        }

        public static int MenuFuncionario(){
            Console.Clear();
            List<Pessoa> pessoas = PessoaRepository.findAll();
            Table.PrintLine();
            Table.PrintRow("##### Serviços Disponiveis #####");
            Table.PrintLine();
            Table.PrintRow("ID", "FUNCIONARIO", "EXPERIENCIA ANOS");
            Table.PrintLine();
            int conta = 1;
            foreach (Pessoa item in pessoas)
            {   
                Funcionario func = Cast.GetFuncionario(item);
                if( func != null ){
                    Table.PrintRow( conta.ToString() , func.Nome , func.AnosExperiencia.ToString() );
                    conta++;
                }
            }
            Table.PrintLine();
            return conta;
        }

        public static int EscolhaFuncionario(){
            int quantidade = MenuFuncionario();
            int opx = int.Parse(Console.ReadLine());
            if(opx >= 1 && opx < quantidade ){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                Thread.Sleep(1500);
                return EscolhaFuncionario();
            }
        }

        public static List<Object> Agendar(){
            List<Pessoa> pessoas = PessoaRepository.findAll();
            List<Servico> servicos = ServicoRepository.findAll();
            List<Pessoa> funcionarios = pessoas.FindAll( x  => Cast.GetFuncionario(x) != null );

            List<Servico> agendaServico = new List<Servico>();
            Funcionario agendaFuncionario = null;

            System.Console.Write("Escolha um Servico: ");
            int opxServico = EscolhaServico();
            agendaServico.Add( servicos[opxServico-1] );

            System.Console.Write("Escolha um Funcionario: ");
            int opxFuncionario = EscolhaFuncionario();
            agendaFuncionario = (Funcionario) funcionarios[opxFuncionario-1];

            System.Console.Write("Informe uma data para agendamento: ");
            string strData = Console.ReadLine();
            DateTime data = Data.Paser(strData);

            return new List<Object>{ agendaServico, agendaFuncionario, data };
        }

        public static void VerAgendamento(){

        }

        public static void Sair(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("##########################################################");
            Console.WriteLine("########## OBRIGADO POR UTILIZAR Charming House ##########");
            Console.WriteLine("##########################################################");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}