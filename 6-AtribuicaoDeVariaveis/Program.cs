using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuição de Variáveis");

            int idade = 21;
            int idadeLuis = idade;
            Console.WriteLine(idade);
            Console.WriteLine(idadeLuis);

            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
