using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000.0;


            int mesesInvestidos = 1;
            while (mesesInvestidos < 13)
            {
                // 0.36% = 0.0036
                valorInvestido += valorInvestido * 0.0036;
                if(mesesInvestidos == 1)
                {
                    Console.WriteLine($"Após {mesesInvestidos} mês, você terá R${valorInvestido} reais");
                }
                else
                {
                    Console.WriteLine($"Após {mesesInvestidos} meses, você terá R${valorInvestido} reais");
                }
                mesesInvestidos++;
            }

            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
