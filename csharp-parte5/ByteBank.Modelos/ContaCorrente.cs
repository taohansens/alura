using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos {
    /// <summary>
    /// Define uma Conta corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente {
        private double _saldo = 100;

        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que zero.</param>
        /// <exception cref="ArgumentException"></exception>
        public ContaCorrente(int agencia, int numero) {
            if (agencia <= 0) {
                ArgumentException excecao = new ArgumentException("A agência da conta deve ser maior que 0.", nameof(agencia));
                throw excecao;
            }
            if (numero <= 0) {
                ArgumentException excecao = new ArgumentException("O número da conta deve ser maior que 0.", nameof(numero));
                throw excecao;
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }
        public int Numero { get; }
        public int Agencia { get; }

        public double Saldo {
            get { return _saldo; }
            set {
                if (value < 0) {
                    return;
                }

                _saldo = value;
            }
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor do saque, que deve ser maior que zero e menor que o <see cref="Saldo"/>.</param>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor" /> for maior que o <see cref="Saldo"/></exception>
        public void Sacar(double valor) {
            if (valor < 0) {
                throw new ArgumentException("Valor inválido para o saque", nameof(valor));
            }
            if (_saldo < valor) {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo, valor);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor) {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino) {
            if (valor <= 0) {
                throw new ArgumentException("Valor inválido para a transferência", nameof(valor));
            }

            try {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex) {
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}