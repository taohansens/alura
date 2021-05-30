using System;

namespace _07_BBank {
    class Program {
        static void Main(string[] args) {
            ContaCorrente conta1 = new ContaCorrente(1, 1457);

            Console.WriteLine(ContaCorrente.totalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(12, 345);
            ContaCorrente conta3 = new ContaCorrente(142, 534);
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);
        }
    }
}
