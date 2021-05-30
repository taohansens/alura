using System;

namespace _04_BBank {
    class Program {

        static void Main(string[] args) {
            string brkl = "==================";

            ContaCorrente contaGustavo = new ContaCorrente();
            contaGustavo.titular = "Gustavo";
            contaGustavo.agencia = 863;
            contaGustavo.numero = 75421;
            contaGustavo.saldo = 101.00;

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 1415;
            contaGabriela.numero = 78745;
            contaGabriela.saldo = 150.0;

            Console.WriteLine("Saldo antes de sacar: " + contaGustavo.saldo);
            Console.WriteLine(brkl);
            double valorSacar = 80;
            bool resultadoSaque = contaGustavo.Sacar(valorSacar);
            Console.WriteLine("\nSacou " +  valorSacar +"? = " + resultadoSaque);
            Console.WriteLine("\nSaldo após sacar:  " + contaGustavo.saldo);
            Console.WriteLine(brkl);
            
            resultadoSaque = contaGustavo.Sacar(valorSacar);
            Console.WriteLine("\nSacou " + valorSacar + "? = " + resultadoSaque);
            Console.WriteLine("\nSaldo após sacar:  " + contaGustavo.saldo);

            Console.WriteLine(brkl);
            
            double valorDepositar = 430;
            contaGustavo.Depositar(valorDepositar);
            Console.WriteLine("Valor depositado: " + valorDepositar);
            Console.WriteLine(brkl);
            Console.WriteLine("Valor após depósito: " + contaGustavo.saldo);

            Console.WriteLine("\nTransferindo R$80.5 de Gustavo para Gabriela");
            Console.WriteLine($"SALDO ANTES = GABRIELA {contaGabriela.saldo} / GUSTAVO {contaGustavo.saldo}");
            Console.WriteLine(brkl);
            contaGustavo.Transferir(80.5, contaGabriela);
            Console.WriteLine($"SALDO DEPOIS = GABRIELA {contaGabriela.saldo} / GUSTAVO {contaGustavo.saldo}");
            Console.ReadLine();
        }
    }
}
