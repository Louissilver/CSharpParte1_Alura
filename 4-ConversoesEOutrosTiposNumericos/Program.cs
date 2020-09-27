using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversão e outros tipos numéricos");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;

            Console.WriteLine("Fim do programa. Tecle Enter para continuar...");
            Console.ReadLine();
        }
    }
}
