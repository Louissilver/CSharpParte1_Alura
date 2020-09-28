using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Desafio Opcional: Fatorial");
            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}! = ");
                for (int j = 1; j <= i; j++)
                {
                    if (j != 1)
                    {
                        Console.Write(" x ");
                    }
                    Console.Write(j);
                }
                fatorial *= i;
                Console.WriteLine($" = {fatorial}");
                Console.WriteLine();
            }
            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
