using System;
using System.Collections.Generic;
namespace GestorAnimais
{
    class Program
    {
        static void Main(string[] args)
        {

    
            List<Animais> animais = new List<Animais>
            {
                new Animais("Elefante", 5000),
                new Animais("Rinoceronte", 2000)
            };          
            string nome = "";

          do
           { 
            Console.WriteLine("Digite o nome do animal: ");
            nome = Console.ReadLine();
            if(nome != "x")
              {
              Console.WriteLine("Digite o peso do animal: ");
              int peso = int.Parse(Console.ReadLine());
              Animais animal = new Animais(nome , peso);
              animais.Add(animal);
              }
            }while(nome != "x");

            Console.WriteLine("Quer definir um peso minimo?");
            string resposta = Console.ReadLine();
            if(resposta == "sim")
            {
                Console.WriteLine("Digite o peso minimo: ");
                int pesoMinimo = int.Parse(Console.ReadLine());
                List<Animais>animaisMP =  GetAnimaisComPesoMaiorQue(pesoMinimo , animais);
                foreach(Animais animal in animaisMP)
                {
                  Console.WriteLine(animal.Nome);
                  Console.WriteLine(animal.Peso);
                }
            }else if(resposta == "nao")
            {
              foreach(Animais animal in animais)
              {
                Console.WriteLine(animal.Nome);
                Console.WriteLine(animal.Peso);
                
              }
            }
          
           static List<Animais> GetAnimaisComPesoMaiorQue(int pesoMinimo , List<Animais> animais)
            {
                List<Animais> animaisComPesoMaiorQue = new List<Animais>();

                  foreach(Animais animal in animais)
                  {
                    if(animal.Peso > pesoMinimo)
                    {
                      animaisComPesoMaiorQue.Add(animal);
                    }
                    
                  }
                  
              return animaisComPesoMaiorQue;
        }
    }
}
}