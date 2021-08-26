using System;
using TaoBank.Models;
using TaoBank.Models.Tools;

namespace TaoBank {
    class Program {
        static void Main(string[] args) {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(2, 54, 7, 32);

            idades.EscreverListaNaTela();
        }


        static void Contas() {
            var rand = new Random();

            ListaDeContaCorrente lista = new();
            int qtdContas = 10;
            for (int i = 0; i < qtdContas; i++) {
                int agencia = rand.Next(100);
                int conta = rand.Next(9999);
                lista.Adicionar(new ContaCorrente(agencia, conta));
            }

            ContaCorrente contaTao = new ContaCorrente(23, 543);

            lista.EscreverListaNaTela();
            Console.WriteLine("======");
            lista.Remover(contaTao);
            Console.WriteLine("Removido");
            lista.EscreverListaNaTela();

            Console.WriteLine("Imprimindo por index. [3]");
            Console.WriteLine(lista[3].Agencia + " . " + lista[3].Numero);
            Console.WriteLine("Params. Adicionando mais contas.");
            lista.AdicionarVarios(
                new ContaCorrente(32, 23456),
                new ContaCorrente(32, 4356),
                new ContaCorrente(32, 1134),
                new ContaCorrente(32, 996457),
                new ContaCorrente(32, 568745));

            lista.Remover(new ContaCorrente(32, 1134));
            lista.EscreverListaNaTela();
        }

        static void TestaArrayContaCorrente() {
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
