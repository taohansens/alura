using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            try {
                var conta1 = new ContaCorrente(456, 13030);
                conta1.Depositar(5000);
                //conta1.Sacar(6000);
                Console.WriteLine(conta1.Saldo);
                 
                var conta2 = new ContaCorrente(452, 13130);
                conta2.Depositar(5000);
                
                // ArgumentExceptionm: Valor
                //conta2.Transferir(-10, conta1);
                conta2.Sacar(7000);
                //conta2.Transferir(6000, conta1);
                Console.WriteLine(conta1.Saldo);

            }
            catch (ArgumentException ae) {
                Console.WriteLine("Argumento com problema: " + ae.ParamName);

                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ae.Message);
            }
            // catch (SaldoInsuficienteException ex){
            //     //Console.WriteLine(ex.Saldo);
            //     //Console.WriteLine(ex.ValorSaque);
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine("Exceção do tipo saldo insuficiente.");
            // }
            catch (OperacaoFinanceiraException ex) {
                Console.WriteLine(ex.Message);

                Console.WriteLine("Informações InnerException: ");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
            }

            // try {
            //     Metodo();
            // }
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine(e.StackTrace);
            //     Console.WriteLine("Não é possível divisão por zero");
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.StackTrace);
            //     Console.WriteLine("Ops. Divisão por Zero!");
            // }

            Console.ReadLine();
        }

        // // Teste com a cadeia de chamada:
        // // Metodo -> TestaDivisao -> Dividir
        // private static void Metodo()
        // {
        //     TestaDivisao(0);
        // }
        //
        // private static void TestaDivisao(int divisor)
        // {
        //     try
        //     {
        //         int resultado = Dividir(10, divisor);
        //         Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        //     }
        //     catch(DivideByZeroException erro)
        //     {
        //         Console.WriteLine(erro.Message);
        //         Console.WriteLine(erro.StackTrace);
        //         Console.WriteLine("Não é possível fazer uma divisão por 0!");
        //     }
        // }
        //
        // private static int Dividir(int numero, int divisor)
        // {
        //     try {
        //         return numero / divisor;
        //     }
        //     catch (DivideByZeroException) {
        //         Console.WriteLine("Erro com divisão por zero");
        //     }
        //
        //     return numero / divisor;
        // }
    }
}