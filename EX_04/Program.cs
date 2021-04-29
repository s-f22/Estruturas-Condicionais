using System;

namespace EX_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade < 8)
            {
                Console.WriteLine("Categoria: INFANTIL A");
            }
            else
            {
                if (idade >=8 && idade < 11)
                {
                    Console.WriteLine("Categoria: INFANTIL B");
                }
                else
                {
                    if (idade >= 11 && idade < 14)
                    {
                        Console.WriteLine("Categoria: JUVENIL A");
                    }
                    else
                    {
                        if (idade >= 14 && idade < 18)
                        {
                            Console.WriteLine("Categoria: JUVENIL B");
                        }
                        else
                        {
                            if (idade >= 18)
                            {
                                Console.WriteLine("Categoria: MAIORES DE 18 ANOS");
                            }
                            else
                            {
                                Console.WriteLine("Idade não permitida.");
                            }
                        }
                    }
                }
            }
        }
    }
}
