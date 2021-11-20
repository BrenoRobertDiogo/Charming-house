using System;

namespace Charming_house.utils
{
    public class Logger
    {
        public static void Info(string mensagem){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Warn(string mensagem){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Debug(string mensagem){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}