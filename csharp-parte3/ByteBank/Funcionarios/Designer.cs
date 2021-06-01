﻿
namespace ByteBank.Funcionarios {
    public class Designer : Funcionario {
        public Designer(string cpf) : base(cpf, 3000) {
        }
        public override void AumentarSalario() {
            Salario *= 1.11;
        }

        public override double GetBonificacao() {
            return Salario *= 0.17;
        }
    }
}
