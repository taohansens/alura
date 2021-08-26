﻿using System;
using TaoBank.Models;

namespace TaoBank {
    class Program {
        static void Main(string[] args) {
            ContaCorrente[] contas = new ContaCorrente[] {
            new ContaCorrente(0254, 5654645),
            new ContaCorrente(0254, 78412),
            new ContaCorrente(0254, 965234)
            };

            for (int i = 0; i < contas.Length; i++) {
                Console.WriteLine(contas[i].Agencia + " " + contas[i].Numero);
            }
        }

        static void TestaArray() {
            // Array de inteiros
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 20;
            idades[2] = 30;
            idades[3] = 22;
            idades[4] = 34;

            for (int i = 0; i < idades.Length; i++) {
                Console.WriteLine(idades[i]);
            }

            bool[] arrayDeBooleans = new bool[2];

            arrayDeBooleans[0] = true;
            Console.WriteLine("Booleans");
            for (int i = 0; i < arrayDeBooleans.Length; i++) {
                Console.WriteLine(arrayDeBooleans[i]);
            }

        }
    }
}
