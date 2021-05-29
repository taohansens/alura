using System;

namespace p14.DesafioFatorial {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Desafio Fatorial");
            int fatorial = 1;

            for (int i = 1; i < 11; i++) {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }
    }
}
