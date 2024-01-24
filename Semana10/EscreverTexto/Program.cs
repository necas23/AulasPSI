using System;
using System.IO;
using System.Text;

namespace EscreverTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int numint;
            double numreal;

            Console.WriteLine("Insira o nome do ficheiro que quer abrir: ");

            string resposta = Console.ReadLine();
            string ficheiro = "ficheiro2.txt";
            TextWriter texto2 = File.CreateText("./" + resposta);

            Console.WriteLine("Insira um número inteiro: ");
            numint = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Insira um número real: ");
            numreal = Convert.ToDouble(Console.ReadLine());

            texto2.WriteLine(numint);
            texto2.WriteLine(numreal);
            texto2.Close();
        }
    }
}
