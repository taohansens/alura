using System;

namespace ByteBank {
    public class SaldoInsuficienteException : OperacaoFinanceiraException {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException() {
        }

        public SaldoInsuficienteException(double saldo, double saque)
            : this("Tentativa de saque no valor de R$" + saque + " em uma conta com saldo de R$" + saldo) {
            Saldo = saldo;
            ValorSaque = saque;
        }
        
        public SaldoInsuficienteException(string message) : base(message) {
        }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}