using System;
using Charming_house.exception;

namespace Charming_house.controllers
{
    public class Data
    {
        public static DateTime Paser(string data){
            string[] arr = data.Split("/");
            if( arr.Length != 3 ) throw new  ExDateParse("Formato da data invalido, Ex: 12/01/1998");
            return new DateTime(int.Parse(arr[2]), int.Parse(arr[1]), int.Parse(arr[0]));
        }
    }
}