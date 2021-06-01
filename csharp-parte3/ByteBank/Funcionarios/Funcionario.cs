
namespace ByteBank.Funcionarios {
    public class Funcionario {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario) {
            CPF = cpf;
            TotalDeFuncionarios++;
            Salario = salario;
        }

        public virtual void AumentarSalario() {
            Salario *= 1.1;
        }
        
        public virtual double GetBonificacao() {
            return Salario * 0.10;
        }
    }
}
