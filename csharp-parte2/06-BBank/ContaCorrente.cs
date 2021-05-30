using _06_BBank;
public class ContaCorrente {

    private Cliente _titular;
    private int _agencia;
    private int _numero;
    private double _saldo = 100;

    public Cliente Cliente { get => _titular; set => _titular = value; }
    public int Agencia { get => _agencia; set => _agencia = value; }
    public int Numero { get => _numero; set => _numero = value; }
    
    public double Saldo {
        get 
            { return _saldo; }
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