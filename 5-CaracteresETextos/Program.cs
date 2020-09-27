using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Textos e Caracteres");

            // character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia";
            Console.WriteLine(titulo);
            string cursosProgramacao = 
@" - .NET 
 - Java
 - JavaScript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Fim da execução. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
