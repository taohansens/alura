using System;

namespace _8_Condicionais2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 7 - condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao > 18 || acompanhado) {
                Console.WriteLine("Pode entrar.");
            }
            else {
                Console.WriteLine("Não pode entrar.");
            }

            if (idadeJoao > 18 && quantidadePessoas >= 2) {
                Console.WriteLine("Pode entrar.");
            }
            else {
                Console.WriteLine("Não pode entrar.");
            }
            Console.ReadLine();
        }
    }
}


