using System;
using RPG_Dio.src.Entities;


namespace RPGDio
{
    class Program
    { 
        static void Main(string[] args){
            Hero Arus = new Hero("Arus",42,"Knight");
            Wizard Jennica = new Wizard("Jenicca",42,"White Wizard");
            Console.WriteLine(Arus.ToString());
            Console.WriteLine(Jennica.ToString());

        }
    }
}