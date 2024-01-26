using System;

namespace OMeuJogoMVC
{
    public class Controlador
    {
        private int numInimigos;
      
        private Inimigo[] arrayInimigos;

        public Controlador(Inimigo[] array)
        {
            arrayInimigos = array;
        }

        public void Iniciar(View view)
        {
            numInimigos = view.Inimigos();
            arrayInimigos = new Inimigo[numInimigos];
            for(int i = 0; i < numInimigos; i++)
            {
                Inimigo inim = new Inimigo(view.NomeInimigo(i));
                arrayInimigos[i] = inim;
                arrayInimigos[i].Danificar(50);
            }
          
            view.ImprimirNomes("Lista de inimigos: ");
            for(int i = 0; i < numInimigos; i++)
            {
                view.ImprimirInimigo(i, arrayInimigos);
            }
        }
    }
}