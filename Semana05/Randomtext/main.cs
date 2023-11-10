using System;

  class Program
    {
        static void Main(string[] args)
        {
          // Variável para guardar input do utilizador
          int n;

          // Variável para guardar soma dos dados
          int soma = 0;

          // Variável de Classe Random
          Random rnd = new Random();
          
          // Pedir input ao utilizador e guardar
          Console.WriteLine("Introduza o número de dados: ");
          n = Convert.ToInt32(Console.ReadLine());
          
          // Ciclo FOR
          for(int i = 0; i <= n; i++){
            int aux = rnd.Next(1,5);
            Console.WriteLine(aux);
            soma += aux;
          }
          
          Console.WriteLine($"Soma de todos os dados: {soma}");
        }
    }