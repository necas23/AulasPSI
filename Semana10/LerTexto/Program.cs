using System;
using System.IO;
using System.Text;

namespace LerTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int numint;
            double numreal;

            Console.WriteLine("Insira o nome do ficheiro que quer ler: ");

            string resposta = Console.ReadLine();
            string ficheiro = "ficheiro2.txt";
            TextReader texto2 = File.OpenText(resposta);

            Console.WriteLine(texto2.ReadLine());
            Console.WriteLine(texto2.ReadLine());
            texto2.Close();
        }
    }
}
