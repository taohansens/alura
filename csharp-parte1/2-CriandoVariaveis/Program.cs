﻿using System;

namespace _2_CriandoVariaveis {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);
            idade = (10 + 4) * 2;
            Console.WriteLine(idade);

            Console.WriteLine("Sua idade é " + idade + "!");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
