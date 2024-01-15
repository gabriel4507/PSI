using System;
using System.IO;
using System.IO.Compression;

namespace Descompressor
{
    class Program
    {
        private static void Main(string[] args)
        {
            
          
          string ficheiro = "ficheiro.txt.gz";
          Comprime(ficheiro);
          Descomprime(ficheiro);

           
        }

        private static void Comprime(string ficheiro)
        {
            string line;

            FileStream fs = new FileStream(ficheiro, FileMode.Create, FileAccess.Write);

            GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

            StreamWriter sw = new StreamWriter(gzs);

            while ((line = Console.ReadLine()).Length > 0)
            {
                sw.WriteLine(line);
            }

            sw.Close();

          
        }

          private static void Descomprime(string ficheiro)
        {  


          string line;

          FileStream fs = new FileStream(ficheiro, FileMode.Open, FileAccess.Read);

          GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);

          StreamReader sw = new StreamReader(gzs);

          while ((line = sw.ReadLine()) != null)
          {
              Console.WriteLine(line);
          }

          sw.Close();
        
        }
    }
}
