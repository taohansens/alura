using System;

namespace _04_BBank {
    class Program {
        static void Main(string[] args) {
            ContaCorrente contaGustavo = new ContaCorrente();
            contaGustavo.titular = "Gustavo";
            contaGustavo.agencia = 863;
            contaGustavo.numero = 75421;
            contaGustavo.saldo = 101.00;

            Console.WriteLine("Saldo antes de sacar: " + contaGustavo.saldo);

            double valorSacar = 80;
            bool resultadoSaque = contaGustavo.Sacar(valorSacar);
            Console.WriteLine("\nSacou " +  valorSacar +"? = " + resultadoSaque);

            Console.WriteLine("\nSaldo após sacar:  " + contaGustavo.saldo);
            
            // segunda tentativa
            resultadoSaque = contaGustavo.Sacar(valorSacar);
            Console.WriteLine("\nSacou " + valorSacar + "? = " + resultadoSaque);

            Console.WriteLine("\nSaldo após sacar:  " + contaGustavo.saldo);



            Console.ReadLine();
        }
    }
}
