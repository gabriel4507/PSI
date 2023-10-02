using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            string psi = "psiii";
            string aula = @"aulass";
            string b = @"""Uma string entre aspas""";
            string e = @"\Uma string sem aspas";
            string t = "\u00A9 e \u2665";
            string i = @"\u00A9 e \u2665 sem UTF";

            Console.WriteLine(psi);
            Console.WriteLine(aula);
            Console.WriteLine(b);
            Console.WriteLine(e);
            Console.WriteLine(t);
            Console.WriteLine(i);
        }
    }
}
