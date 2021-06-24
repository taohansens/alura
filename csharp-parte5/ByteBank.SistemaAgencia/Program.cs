using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia {
    class Program {
        static void Main(string[] args) {
            ContaCorrente conta = new ContaCorrente(847, 3356465);
            //Teste Documentação
            //conta.Sacar();
            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
