using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_DesafioMultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Desafio Opcional: Múltiplos de 3");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
