using System;

namespace OMeuJogoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimigo[] array = new Inimigo[0];

          // Criar o modelo (classe Tabuleiro faz parte do modelo)
          Tabuleiro tabuleiro = new Tabuleiro();

          // Criar o controlador, passando uma referência aos elementos do modelo
          Controller controller = new Controller(tabuleiro);

          // Criar a view, passando uma referência ao controlador
          View view = new View(controller);

          // Correr o jogo, passando uma referência da view ao controlador
          controller.Iniciar(view);
        }
    }
}