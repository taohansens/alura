using System;
using System.Collections.Generic;
using TaoBank.Models;
using TaoBank.Models.Tools;
using TaoBank.System;

namespace TaoBank {
    class Program {
        static void Main(string[] args) {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);

            idades.Remove(5);

            // Extend from ListExtensoes
            idades.AdicionarVarios(33, 44, 88);

            Console.WriteLine(idades);

        }
    }
}
