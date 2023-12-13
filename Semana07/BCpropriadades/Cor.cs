using System;

namespace BolasColoridas
{
    public class Cor
    {
       public byte Red { get; set;}
       public byte Green { get; set;}
       public byte Blue  { get; set;}
       public byte Alpha { get; set;}
       public int Cinzento{ get{ return (Red + Green + Blue) / 3;}}

        // Construtor que aceita todos os parâmetros necessários para
        // inicializar o estado de uma Cor
        public Cor(byte red, byte green, byte blue, byte alpha)
        {
            Red = Red;
            Green = Green;
            Blue = Blue;
            Alpha = Alpha;
        }

        // Construtor que aceita parâmetros RGB e define alpha com
        // o valor máximo
        public Cor(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = byte.MaxValue;
        }

       

    
        // Getter que retorna o grau de cinzento da cor
        public int GetCinzento()
        {
            return (red + green + blue) / 3;
        }
    }
}