﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Metodo();
            }
            catch (NullReferenceException erro) {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Caiu nessa primeiro!");
            }
            catch(Exception erro)
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }
            
            try {
                Dividir(4,0);
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Ops. Divisão por Zero!");
            }
            
            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por 0!");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            try {
                return numero / divisor;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Erro com divisão por zero");
            }

            return numero / divisor;
        }
    }
}
