using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João tem mais de 18 anos, então pode entrar.");
            }
            else if (idadeJoao <= 18 && acompanhado == true)
            {
                Console.WriteLine("João é menor de 18 anos, mas está acompanhado, então pode entrar.");
            }
            else
            {
                Console.WriteLine("João não possui mais de 18 anos, então não pode entrar.");
            }



            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
