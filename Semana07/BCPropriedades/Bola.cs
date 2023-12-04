using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
          private Cor cor;
          private float raio;
          private int nvezes;

          public Bola(float raio, Cor cor)
          {
            this.cor = cor;
            this.raio = raio;
            nvezes = 0;
          }

          public void pop()
          {
            raio = 0;  
          }

          public void atirar()
          {
            if(raio > 0) nvezes++;  
          }

          public int nvezes()
          {
            return nvezes;
          }
      }
}
