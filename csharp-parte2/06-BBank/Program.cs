using System;

namespace _06_BBank {
    class Program {

        static void Main(string[] args) {
            string brkl = "==================";

            Cliente c1 = new Cliente();
            c1.Nome = "Gabriela";
            c1.Profissao = "Estudante";
            c1.Cpf = "342.334.232-23";

            ContaCorrente conta = new ContaCorrente();
            conta.Agencia = 3234;
            conta.Cliente = c1;
            conta.Numero = 445;
            conta.Saldo = 150;

            conta.Depositar(10);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Cliente.Nome);



        }
    }
}
