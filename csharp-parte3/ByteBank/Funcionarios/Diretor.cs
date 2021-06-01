
namespace ByteBank.Funcionarios {
    class Diretor : Funcionario {
        public Diretor(string cpf, double salario) : base(cpf, salario) {

        }
        public override double GetBonificacao() {
            return Salario * 0.5;
        }

        public override void AumentarSalario() {
            Salario *= 1.15;
        }
    }
}
