using System;

namespace exe._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade=int.Parse(Console.ReadLine());

            int meses=idade*12;
            int dias=idade*365;
            int horas=dias*24;
            int minutos=horas*60;

            Console.WriteLine("Idade em meses "+meses);
            Console.WriteLine("Idade em dias "+dias);
            Console.WriteLine("Idade em horas "+horas);
            Console.WriteLine("Idade em minutos "+minutos);
        }
    }
}
