using System;

namespace _5_CaracteresETextos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Banco do Brasil" + 2021;
            string concaten = @"CSharp
            - 2021 
            - testando";
            Console.WriteLine(titulo);
            Console.WriteLine(concaten);







        }
    }
}
