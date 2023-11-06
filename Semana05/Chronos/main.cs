using System;
using System.Diagnostics;
using System.Threading;
class Program{
  public static void Main (string[] args) {

    Stopwatch cronometro1 = new Stopwatch(), cronometro2 = new Stopwatch();

    // Começar Contagem Cronómetro 1.
    cronometro1.Start();

    // Pausar Cronómetro 1
    Thread.Sleep(1000);

    // Começar Contagem Cronómetro 2.
    cronometro2.Start();

    // Pausar Cronómetro 2.
    Thread.Sleep(1000);

    // Parar a Contagem dos 2 Cronómetros.
    cronometro1.Stop();
    cronometro2.Stop();

    // Mostrar Tempo Decorrido.
    Console.WriteLine("Cronómetro 1: " + cronometro1.ElapsedMilliseconds);
    Console.WriteLine("Cronómetro 2: " + cronometro2.ElapsedMilliseconds);
  }
}
