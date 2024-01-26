using System;

namespace OMeuJogoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
          Inimigo[] array = new Inimigo[0];

          Controlador controller = new Controlador(array);

          View view = new View(controller);

          controller.Iniciar(view);
        }
    }
}