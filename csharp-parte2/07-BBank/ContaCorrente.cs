using _07_BBank;
public class ContaCorrente {

    public static int totalDeContasCriadas { get; private set; }
    private Cliente _titular;
    private int _agencia;
    private int _numero;
    private double _saldo = 100;


    public ContaCorrente(int agencia, int numero) {
        Agencia = agencia;
        Numero = numero;
        totalDeContasCriadas++;
    }

    public Cliente Cliente { get => _titular; set => _titular = value; }
    public int Agencia {
        get => _agencia;
        set {

            if (value <= 0) {
                return;
            }

            _agencia = value;
        }
    }
    public int Numero {
        get => _numero;
        set {
            if (value <= 0) {
                return;
            }

            _numero = value;
        }
    }

    public double Saldo {
        get { return _saldo; }
        set {
            if (value < 0) {
                return;
            }
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