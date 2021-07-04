using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args) {
            
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
