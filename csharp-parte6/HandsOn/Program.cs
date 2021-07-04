using System;

namespace HandsOn {
    class Program {
        public static void Main(string[] args) {
            Parte1();
        }

        private static void Parte1() {
            var url = "pagina?argumentos";
            var url2 = url.Substring(7);
            Console.WriteLine(url2);
        }
    }
}