using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQLeitor
{
    class Program
    {
        static void Main(string[] args)
        {
            string livro = "livro.txt";
            string[] linhas = System.IO.File.ReadAllLines(livro);

                int linhasMaisDe30Caracteres = 
                (from linha in linhas
                where linha.Length > 30
                select linha).Count();
                Console.WriteLine("Livros com mais de 30 caracteres: " + linhasMaisDe30Caracteres); 

                double media =
                (from linha in linhas
                select linha.Length).Average();
                Console.WriteLine($"Média de caracteres por linha: {media:F2}");

                bool temLinhaComMaisDe120Caracteres =
                (from linha in linhas
                where linha.Length > 120
                select linha).Any();
                Console.WriteLine("Existe linha com mais de 120 caracteres: " + temLinhaComMaisDe120Caracteres);
          
                IEnumerable<string> linhasComLetraB  = 
                from linha in linhas  
                where linha.Contains("B")
                select linha.Split(' ')[0];

                foreach (string linha in linhasComLetraB)
                {
                  Console.WriteLine(linha);
                }    

          

                
                
              

          

            
        }
    }
}
