
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios {
    public class GerenteDeConta : Autenticavel {
        public GerenteDeConta(string cpf, double salario) : base(salario, cpf) {
        }

        public string Senha { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override void AumentarSalario() {
            Salario *= 1.05;
        }

        public override double GetBonificacao() {
            return Salario * 0.25;
        }
    }
}
