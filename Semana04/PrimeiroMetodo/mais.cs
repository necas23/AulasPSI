using System;

class Program {
  public static void Main (string[] args) 
  {
    ContarAte10();
    Console.WriteLine();
    ContarAte10();
    Console.WriteLine();
  }

  private static void ContarAte10()
  {
    for(int i = 1; i < 11; i++){
      Console.WriteLine(i);
    }
  }
}