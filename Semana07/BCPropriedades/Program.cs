using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
          cor aa = new Cor(25, 37, 41);
          cor bb = new Cor(27, 41, 53);
          cor cc = new Cor(8, 24, 35);
          cor dd = new Cor(12, 55, 43);
          cor zz = new Cor(2, 5, 34);

          Bola a = new Bola(2, aa);
          Bola a = new Bola(35, bb);
          Bola a = new Bola(12, cc);
          Bola a = new Bola(6, dd); 
          Bola a = new Bola(9, zz);

          Console.WriteLine("A bola A foi atirada. ");
          a.Atirar();
          Console.WriteLine("A bola B foi atirada. ");
          b.Atirar();
          Console.WriteLine("A bola C foi atirada. ");
          c.Atirar();
          Console.WriteLine("A bola D foi atirada. ");
          d.Atirar();
          Console.WriteLine("A bola Z foi atirada. ");
          z.Atirar();

          Console.WriteLine("A bola A foi rebentada. ");
          a.Pop();
          Console.WriteLine("A bola B foi rebentada. ");
          b.Pop();
          Console.WriteLine("A bola C foi rebentada. ");
          c.Pop();
          Console.WriteLine("A bola D foi rebentada. ");
          d.Pop();
          Console.WriteLine("");

          Console.WriteLine("A bola A tem: ");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de vermelho: {aa.GetRed()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de verde: {aa.GetGreen()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de azul: {aa.GetAzul()}");
          Console.WriteLine("");
          Console.WriteLine($"Raio: {a.GetRaio()}");
          Console.WriteLine("");
          Console.WriteLine($"Número de vezes que a bola A foi atirada: {a.Nvezes()}");

          Console.WriteLine("");
          Console.WriteLine("A bola B tem: ");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de vermelho: {bb.GetRed()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de verde: {bb.GetGreen()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de azul: {bb.GetAzul()}");
          Console.WriteLine("");
          Console.WriteLine($"Raio: {b.GetRaio()}");
          Console.WriteLine("");
          Console.WriteLine($"Número de vezes que a bola B foi atirada: {b.Nvezes()}");

          Console.WriteLine("A bola C tem: ");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de vermelho: {cc.GetRed()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de verde: {cc.GetGreen()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de azul: {cc.GetAzul()}");
          Console.WriteLine("");
          Console.WriteLine($"Raio: {c.GetRaio()}");
          Console.WriteLine("");
          Console.WriteLine($"Número de vezes que a bola C foi atirada: {c.Nvezes()}");

          Console.WriteLine("A bola D tem: ");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de vermelho: {dd.GetRed()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de verde: {dd.GetGreen()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de azul: {dd.GetAzul()}");
          Console.WriteLine("");
          Console.WriteLine($"Raio: {d.GetRaio()}");
          Console.WriteLine("");
          Console.WriteLine($"Número de vezes que a bola D foi atirada: {d.Nvezes()}");

          Console.WriteLine("A bola Z tem: ");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de vermelho: {zz.GetRed()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de verde: {zz.GetGreen()}");
          Console.WriteLine("");
          Console.WriteLine($"Quantidade de azul: {zz.GetAzul()}");
          Console.WriteLine("");
          Console.WriteLine($"Raio: {z.GetRaio()}");
          Console.WriteLine("");
          Console.WriteLine($"Número de vezes que a bola Z foi atirada: {z.Nvezes()}");
        }
    }
}
