
namespace ByteBank.Funcionarios {
    public abstract class Funcionario {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario) {
            CPF = cpf;
            TotalDeFuncionarios++;
            Salario = salario;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
        
    }
}
