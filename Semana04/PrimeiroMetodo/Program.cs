using System;

namespace PrimeiroMetodo
{
    class Program
    {
        private static void ContarAte10 (){

                ContarAteN(10);
            
        }

        static void Main(string[] args)
        {
            ContarAte10();

            Console.WriteLine();

            ContarAte10();
            Console.WriteLine();

            ContarAteN(20);
        Console.WriteLine();

ContarAteN(2, 4);


        }


        private static void ContarAteN(int nr){

            for(int i = 1; i <= nr; i++){

                Console.WriteLine(i);
            }
        }
private static void ContarAteN( int nr, int ns){

            for(int i = nr; i <= ns; i++){
            
                Console.WriteLine(i);
            }

}


    }
}
    