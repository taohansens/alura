using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
    public class ContaCorrente {
        private double _saldo = 100;

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

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }
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

        public bool Sacar(double valor) {
            if (_saldo < valor) {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor) {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (_saldo < valor) {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}