using System;

namespace OMeuJogoMVC
{
    public class View
    {
        private Controlador controller;
      
        public View(Controlador controlador)
        {
            controller = controlador;
        }

        public int Inimigos()
        {
            Console.Write("Insira o número inimigos: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string NomeInimigo(int i)
        {
            Console.Write($"Introduza o nome para o inimigo: ");
            return Console.ReadLine();
        }

        public void ListaInimigos()
        {
           Console.WriteLine($"Lista de inimigos: ");    
        }

        public void ImprimirNomes(string nomes)
        {
            Console.WriteLine(nomes);  
        }

        public void ImprimirInimigo(int i, Inimigo[] inimigos2)
        {
          Console.WriteLine($"\tInimigo {i + 1}");
          Console.WriteLine($"\t\tNome: {inimigos2[i].GetNome()}");
          Console.WriteLine($"\t\tVida: {inimigos2[i].GetVida()} {inimigos2[i].GetEscudo()}");
        }
    }
}