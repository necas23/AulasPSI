using System;

namespace OMeuJogoMVC
{
    public class Inimigo
    {
        private string nome;
        private float vida;
        private float escudo;

        private static int numAbast;

        public Inimigo(string nome)
        {
            SetNome(nome);
            vida = 100;
            escudo = 100;
        }

        static Inimigo()
        {
            numAbast = 0;
        }

        public string GetNome()
        {
            return nome;
        }

        public float GetVida()
        {
            if (vida < 50) vida = 50;
            return vida;
        }

        public float GetEscudo()
        {
            return escudo;
        }

        public static int GetNumAbast()
        {
            return numAbast;
        }

        public void SetNome(string novoNome)
        {
            string trimNome = novoNome.Trim();
            this.nome = trimNome;
        }

        public void Danificar(float dano)
        {
            escudo -= dano;

            if (escudo < 0)
            {
                float residual = -escudo;

                escudo = 0;
                vida -= residual;
            }

            if (vida < 0) vida = 0;
        }

        public void Abastecer(Abastecimento ab, float valor)
        {
            numAbast++;

            if (ab == Abastecimento.Vida)
            {
                vida += valor;
                if( vida > 100) vida = 100;
            }
            if (ab == Abastecimento.Escudo)
            {
                escudo += valor;
                if (escudo > 100) escudo = 100;
            }
        }
    }
}