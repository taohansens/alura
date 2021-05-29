using System;

namespace _4_ConversoesEOutrosTiposNumericos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 4");
            
            double salario;
            salario = 1200.40;

            // int = valores até 32bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // long = variavel até 64bits
            long idade;
            idade = 13000000000000;
            Console.WriteLine(idade);

            // short = variavel 16bis
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);


            float altura = 1.80f;
            Console.WriteLine(altura);

        }
    }
}
