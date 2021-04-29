using System;

namespace EX_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do funcionário: R$");
            float salario = float.Parse(Console.ReadLine());

            if (salario > 500)
            {
                salario = salario * 1.3f;
                Console.WriteLine("O salario reajustado é de: R$" + Math.Round(salario, 2));
            }
            else
            {
                Console.WriteLine("Este salário não possui direito a aumento.");
            }
        }
    }
}
