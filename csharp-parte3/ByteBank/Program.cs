using ByteBank.Funcionarios;
using System;


namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());


            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "323.434.546-11";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia Funcionário Diretor: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
        }
    }
}
