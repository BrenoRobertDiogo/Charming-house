using System;
using Charming_house.controllers;
using Charming_house.exception;
using Charming_house.utils;
using Charming_house.views;
using Charming_house.models;
using System.Collections.Generic;
using Charming_house.repository;
using System.Threading;

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



            Cliente cliente = (Cliente)Autenticacao.autentica("breno", "12345");
            while (true)
            {
                int escolha = App.EscolhaEntrada();
                if (escolha == 1)
                {
                    try
                    {
                        Console.Clear();
                        System.Console.Write("Informe seu usuáro: ");
                        string user = Console.ReadLine();

                        System.Console.Write("Informe sua senha: ");
                        string pass = Console.ReadLine();

                        Cliente client = (Cliente)Autenticacao.autentica(user, pass);

                        while (true)
                        {
                            int opcao = App.EscolhaPrograma();
                            Console.Clear();
                            if (opcao == 1)
                            {
                                List<Agendamento> agendamentos = AgendamentoRepository.findAll();
                                var agendamento = App.Agendar(cliente);
                                agendamentos.Add(agendamento);
                                AgendamentoRepository.Save(agendamentos);
                                Console.Clear();
                                Logger.Info("Agendamento cadastrado com sucesso!");
                                Thread.Sleep(1500);
                                
                            }
                            else if (opcao == 2)
                            {
                                App.VerAgendamento(cliente);
                                System.Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Logger.Info("Deslogando...");
                                Thread.Sleep(1500);

                                break;
                            }

                        }

                    }
                    catch (ExAutentica ex)
                    {
                        Console.Clear();
                        Logger.Warn(ex.Message);
                        Thread.Sleep(1500);

                    }

                }
                else if (escolha == 2)
                {
                    // usuario
                    System.Console.Write("Informe o usuario: ");
                    var usuario = Console.ReadLine();
                    // senha
                    System.Console.Write("Informe a senha: ");
                    var senha = Console.ReadLine();
                    // nome
                    System.Console.Write("Informe o nome: ");
                    var nome = Console.ReadLine();
                    // idade
                    System.Console.Write("Informe a idade: ");
                    var idade = int.Parse(Console.ReadLine());

                    try
                    {
                        Autenticacao.cadastro(usuario, senha, nome, idade);
                        Console.Clear();
                        Logger.Info("Cadastrado com sucesso!");
                        Thread.Sleep(1500);
                    }
                    catch (ExCadastro ex)
                    {
                        Console.Clear();
                        Logger.Warn(ex.Message);
                        Thread.Sleep(1500);
                    }

                }
                else if (escolha == 0)
                {
                    App.Sair();
                    break;
                }
            }


        }
    }
}
