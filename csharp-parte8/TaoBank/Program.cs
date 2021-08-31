using System;
using System.Collections.Generic;
using TaoBank.Models;
using TaoBank.Models.Tools;
using TaoBank.System;
using TaoBank.Models.Comparadores;

namespace TaoBank {
    class Program {
        static void Main(string[] args) {
            var contas = new List<ContaCorrente>() {
                new ContaCorrente(112, 1009),
                new ContaCorrente(341, 99999),
                new ContaCorrente(341, 1001),
                new ContaCorrente(330, 10014),
                new ContaCorrente(112, 1008)
            };
            //contas.Sort();
            contas.Sort(new ComparadorContaCorrentePorAgencia());

        }

        static void list() {
            var idades = new List<int>();
            var nomes = new List<string>();

            nomes.Add("Luan");
            nomes.Add("Terrano");
            nomes.Add("Prielo");

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);

            idades.Remove(5);

            // Extend from ListExtensoes Generics
            idades.AdicionarVarios(33, 44, 88, 69);

            idades.Sort();
            nomes.Sort();
            Console.WriteLine(idades);
            Console.WriteLine(nomes);

        }
    }
}
