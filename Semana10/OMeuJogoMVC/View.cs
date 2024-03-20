using System;

namespace OMeuJogoMVC
{
    class View
    {

        private Controller controller;
      
        public View(controller controller)
        {
            this.controller = controller; 
        }

        public int Nrinimigos()
        {
        
          Console.Write("Insere o número de inimigos: ");

          // Guardar input do utilizador na variável correspondente
          numInimigos = Convert.ToInt32(Console.ReadLine());

          // Retornar a variável
          return numInimigos;
        }
    }
}