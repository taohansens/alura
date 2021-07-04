using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args) {
            // REGEX
            string texto = "O número da casa é 403 e o código é 1.2-4 e ok";
            string pattern = "[0-9][.][0-9][-][0-9]";
            Console.WriteLine(Regex.IsMatch(texto, pattern)); // Retorna True ou False
            Match resultado = Regex.Match(texto, pattern);
            Console.WriteLine(resultado);
            Console.WriteLine("=======");

            string texto2 = "O celular é 84334-2394, me ligue.";
            string padrao = "[0-9]{4,5}-?{0,1}[0-9]{4}"; // Regex para _4 até 5 numeros_ - _4 numeros_ com hífen ou sem hífen;
            Match resultado2 = Regex.Match(texto2, padrao);
            Console.WriteLine(resultado2);



            // string urlTest = "http://www.bytebank.com/cambio";
            // int indiceByteBank = urlTest.IndexOf("http://www.bytebank.com");
            // urlTest.StartsWith("http://www.bytebank.com");
            // urlTest.EndsWith("cambio");
            // urlTest.Contains("bytebank");



            // string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            // ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
            // string valor = extratorDeValores.GetValor("moedaOrigem");
            // Console.WriteLine("Valor de moedaOrigem: " + valor);
            // Console.ReadLine();

            // Testando o método remove.
            // string testeRemocao = "primeiraParte&segundaParte";
            // int indiceEComercial = testeRemocao.IndexOf('&');
            // Console.WriteLine(testeRemocao.Remove(indiceEComercial));
            // Console.ReadLine();


            // <nome> = <valor>
            // string palavra = "moedaOrigem=real&moedaDestino=dolar";
            // string nomeArgumento = "moedaDestino";
            //
            // int indice = palavra.IndexOf(nomeArgumento);
            // Console.WriteLine(indice);
            //
            // Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
            //
            // Console.WriteLine(palavra);
            // Console.WriteLine(palavra.Substring(indice));
            // Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
            // Console.ReadLine();
            //
            // // Testando o IsNullOrEmpty
            // string textoVazio = "";
            // string textoNulo = null;
            // string textoQualquer = "kjhfsdjhgsdfjksdf";
            // Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            // Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            // Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            // Console.ReadLine();
            //
            //
            //
            //
            //
            //
            // ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");
            //
            // string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            //
            // int indiceInterrogacao = url.IndexOf('?');
            //
            // Console.WriteLine(indiceInterrogacao);
            //
            // Console.WriteLine(url);
            // string argumentos = url.Substring(indiceInterrogacao + 1);
            // Console.WriteLine(argumentos);
            //
            //
            // Console.ReadLine();
        }
    }


}
