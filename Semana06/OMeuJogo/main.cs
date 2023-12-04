using System;

class Program {
  public static void Main (string[] args) {

    // Variável INT
    int numInimigos;

    // Array
    Inimigo[] inimigos;

    // Pedir num de Inimigos ao utilizador
    Console.Write("Insira o número inimigos: ");

    // Guardar input
    numInimigos = Convert.ToInt32(Console.ReadLine());

    // Definir tamanho do array
    inimigos = new Inimigo[numInimigos];

    // Ciclo FOR
    for(int i = 0; i < numInimigos; i++){
      
      string nomeInimigo;
      Console.Write($"Introduza o nome para o inimigo {i + i}: ");

      nomeInimigo = Console.ReadLine();
      Inimigo novoInimigo = new Inimigo(nomeInimigo);

      inimigos[i] = novoInimigo;

      inimigos[i].Danificar(120);
    }

    // Listar inimigos
      Console.WriteLine("Lista de inimigos:");

    // Ciclo FOR para cada instância no array
    for (int i = 0; i < inimigos.Length; i++)
    {        
        // Imprimir nome do inimigo atual
        Console.WriteLine($"\tInimigo {i + 1}");
        Console.WriteLine($"\t\tNome: {inimigos[i].GetNome()}");
        Console.WriteLine($"\t\tVida: {inimigos[i].GetVida()} {inimigos[i].GetEscudo()}");
    }
  }
}
