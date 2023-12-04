using System;

class Inimigo {

    private string nome;
    private float vida;
    private float escudo;
    
    public Inimigo(string nome){
      this.nome = nome;
      vida = 100;
      escudo = 50;
    }

    public string GetNome(){
      return nome;
    }
      
    public void Danificar(float dano){
      escudo -= dano;
      if(escudo < 0){
        float y = escudo;
        escudo = 0
      }
      vida -= dano;
      if(vida < 0) vida = 0;
    }

    public float GetVida(){
      if(vida <= 50){
        vida = 50;
      }
      return vida;
    }

    public float GetEscudo(){
      return escudo;
    }

    public void SetNome(string novoNome){
      string nomeAux = novoNome.Trim();
      this.nome = novoNome;
    }
}
