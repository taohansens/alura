using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia {
    class Program {
        static void Main(string[] args) {
            DateTime dataFimPagamento = new DateTime(2021, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            
            Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(diferenca));
        }
        
    }
}
