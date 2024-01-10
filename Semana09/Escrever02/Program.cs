using System;

namespace Escrever02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Insere um valor: ");
            string[] a = new string[1000];

            do{
              a[i] = Console.ReadLine();
              i++;
            }while(a[i - 1] != "");

            StreamWriter sw = new StreamWriter("ficheiro.txt");
            sw.WriteLine("Olá Mundo!");
            sw.Close();
        }
    }
}
