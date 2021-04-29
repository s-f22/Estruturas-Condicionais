using System;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            float idade = float.Parse(Console.ReadLine());

            float meses = idade * 12;
            float dias = idade * 365;
            float horas = idade * 8760;
            float minutos = idade * 525600;

            Console.WriteLine("Idade em meses: " + meses);
            Console.WriteLine("Idade em dias: " + dias);
            Console.WriteLine("Idade em horas: " + horas);
            Console.WriteLine("Idade em minutos: " + minutos);
        }
    }
}
