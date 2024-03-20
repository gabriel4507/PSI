using System;
using System.IO;

namespace EscrverTexto
{
    class Program
    {

        static void Main(string[] args)
        {

            string 
          

          
            TextWriter sw = File.CreateText(ficheiroTexto) ;

            sw.WriteLine(dadosString);
            sw.WriteLine(dadosInt);
            sw.WriteLine(dadosFloat);
          

          
            sw.Close();
        }
    }
}
