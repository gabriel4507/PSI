using System;
using System.Collections.Generic;

 namespace GestorAnimais
{
    class Animais : IComparable<Animais>
    {
        public string Nome {get;}
        public int Peso {get; set;}

        public Animais(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
          
        }

        public int CompareTo(Animais other)
        {
          if (other == null) return 1;
          return other.Peso.CompareTo(Peso);
        }

        
    }
}
