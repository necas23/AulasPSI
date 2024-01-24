using System;
using System.IO;

namespace LerBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto20;
            int numint20;
            double numreal20;

            Console.WriteLine("Insira o nome do ficheiro que quer ler: ");

            string resposta = Console.ReadLine();
            string ficheiro = "../EscreverBin/ficheiro3.bin";
            BinaryReader texto3 = new BinaryReader(File.Open(ficheiro, FileMode.Open));

            Console.WriteLine(texto3.ReadString());
            Console.WriteLine(texto3.ReadInt32());
            Console.WriteLine(texto3.ReadDouble());
            texto3.Close();
        }
    }
}
