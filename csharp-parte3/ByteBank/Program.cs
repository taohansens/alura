using ByteBank.Funcionarios;
using System;


namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao() {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("458.452.352-27", 5000);
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("124.124.663-23");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("145.452.222-77");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine($"Total de Bonificações: R$" + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
