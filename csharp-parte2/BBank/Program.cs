using System;

namespace BBank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente contaGustavo = new ContaCorrente();
            contaGustavo.titular = "Gustavo";
            contaGustavo.agencia = 863;
            contaGustavo.numero = 75421;
            contaGustavo.saldo = 101.10;

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gustavo";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 75421;
            contaGabriela.saldo = 150.0;

            Console.WriteLine($"{contaGustavo.titular}\n" +
                $"Agência: {contaGustavo.agencia}\n" +
                $"Número: {contaGustavo.numero}\n" +
                $"Saldo: R${contaGustavo.agencia}");
            Console.ReadLine();
        }
    }
}
