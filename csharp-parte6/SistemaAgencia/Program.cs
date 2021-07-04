using System;

namespace SistemaAgencia {
    class Program {
        static void Main(string[] args) {
            
            var url = "pagina?argumentos";
            Console.WriteLine(url);
            
            var url2 = url.Substring(7);
            
            Console.WriteLine(url2);

            Console.ReadLine();
        }
    }
}