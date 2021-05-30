using System;

namespace _05_BBank {
    class Program {

        static void Main(string[] args) {
            string brkl = "==================";

            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.cpf = "784.455.145-22";
            gabriela.profissao = "Estudante";

            ContaCorrente conta = new ContaCorrente();
            conta.cliente = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 147885;

            Console.WriteLine(conta);
            Console.WriteLine(conta.cliente.nome);
            Console.WriteLine(conta.cliente.cpf);
            Console.WriteLine(conta.saldo);



        }
    }
}
