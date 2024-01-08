using System;
using System.IO;

namespace Escrever01
{
    class Program
    {

        static string guardar = "Escrever01.txt";

      
        static void Main(string[] args)
        {
          
            string input;
            string[] dados = new string[5];
            int i = 0;
          
//ler o input do utilizador , uma string de cada vez
//Guardar strings num array, à medida que são lidas

            Console.WriteLine("Introduza os dados:");
          
          do{
               input = Console.ReadLine();
               dados[i] = input;
               i++;
             
          } while (input != "");
    
          File.WriteAllLines(guardar,dados);
          
            Console.WriteLine("Hello, World!");
        }
    }
}
