using System;


        
namespace JogoDoGalo
{
    class Tabuleiro
    {
        private char[,] tabuleiro = new char[3, 3];

        public Tabuleiro()
        {
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = ' ';
                }
            }
        }

        public string Imprimir()
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    output += tabuleiro[i, j] + " ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
    
}
