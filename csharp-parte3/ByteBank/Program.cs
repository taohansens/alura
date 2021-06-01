using ByteBank.Funcionarios;
using System;


namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("546.879.157-20", 2000);

            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);

            Console.WriteLine($"Bonificiação : {carlos.GetBonificacao()}");
            carlos.AumentarSalario();
            Console.WriteLine($"Salário após aumento: {carlos.Salario}");


            Diretor roberta = new Diretor("323.434.546-11", 5000);

            roberta.Nome = "Roberta";

            //            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia Diretor: " + roberta.GetBonificacao());
            //            Console.WriteLine("Bonificação de uma referencia Funcionário Diretor: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(roberta.Nome);
            Console.WriteLine($"Bonificação:  {roberta.GetBonificacao()}");

            roberta.AumentarSalario();
            Console.WriteLine($"Salário após aumento: {roberta.Salario}");

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("\nTotal de funcionarios: " + Funcionario.TotalDeFuncionarios);
        }
    }
}
