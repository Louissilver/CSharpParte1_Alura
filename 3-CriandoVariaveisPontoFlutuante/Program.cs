using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis com ponto flutuante");

            double salario = 1200.70;
            Console.WriteLine(salario);

            double idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 15 / 2;
            Console.WriteLine("15 / 2 = " + idade);

            idade = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + idade);

            Console.WriteLine("Fim do programa. Tecle Enter para continuar...");
            Console.ReadLine();
        }
    }
}
