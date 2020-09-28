using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança com For");

            double valorInvestido = 1000.0;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido += valorInvestido * 0.0036;
                if (i == 1)
                {
                    Console.WriteLine($"Após {i} mês, você terá R${valorInvestido} reais");
                }
                else
                {
                    Console.WriteLine($"Após {i} meses, você terá R${valorInvestido} reais");
                }
            }
            
            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
