using System;

namespace EX_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu? ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o ano atual? ");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;
            float semanas = (idade * 365) / 7;
            Console.WriteLine("Sua idade em anos é " + idade);
            Console.WriteLine("Sua idade em semanas é " + Math.Round(semanas, 2));

        }
    }
}
