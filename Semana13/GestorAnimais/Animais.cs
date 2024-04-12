using System;


 namespace GestorAnimais
{
    class Animais
    {
        public string Nome {get;}
        public int Peso {get; set;}

        public Animais(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
          
        }
    }
}
