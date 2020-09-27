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

            Console.WriteLine("Salário = " + salario);
            Console.WriteLine("Salário em inteiro = " + salarioEmInteiro);

            // long é uma variável 64bits
            long idade = 1300000000000000000;
            // int é uma variável 32bits
            int idadeInt = 1300000000;
            // short é uma variável 16bits
            short idadeShort = 13000;

            // usamos o sufixo f para identificar floats
            float altura = 1.80f;

            Console.WriteLine("Fim do programa. Tecle Enter para continuar...");
            Console.ReadLine();
        }
    }
}
