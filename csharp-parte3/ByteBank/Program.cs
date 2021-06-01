using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;


namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            UsarSistema();
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-55");
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta camila = new GerenteDeConta("145.452.222-77");
            camila.Nome = "Camila";
            camila.Senha = "45122";

            ParceiroComercial pedro = new ParceiroComercial();
            pedro.Senha = "234555";



            Console.WriteLine("DIRETOR SENHA INCORRETA:");
            sistemaInterno.Logar(roberta, "123");
            Console.WriteLine("GERENTE DE CONTA SENHA INCORRETA:");
            sistemaInterno.Logar(camila, "abc");
            Console.WriteLine("DIRETOR SENHA CORRETA:");
            sistemaInterno.Logar(roberta, "1234");
            Console.WriteLine("PARCEIRO SENHA INCORRETA:");
            sistemaInterno.Logar(pedro, "1234");

            Console.WriteLine("PARCEIRO SENHA CORRETA:");
            sistemaInterno.Logar(pedro, "234555");



        }

        public static void CalcularBonificacao() {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("458.452.352-27");
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
