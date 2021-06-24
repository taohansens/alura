﻿
namespace ByteBank.Modelos.Funcionarios {
    public abstract class Funcionario {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf) {
            CPF = cpf;
            TotalDeFuncionarios++;
            Salario = salario;
        }

        public abstract void AumentarSalario();
       protected internal abstract double GetBonificacao();
        
    }
}
