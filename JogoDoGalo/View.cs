using System;

namespace JogoDoGalo
{
    class View
    {
        private Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
        }

        public void Iniciar()
        {
            Console.WriteLine("Iniciando o jogo...");
            Console.WriteLine("Jogador 1: " + controller.jogador1.Nome);
            Console.WriteLine("Jogador 2: " + controller.jogador2.Nome);
            Console.WriteLine("Tabuleiro:");
            Console.WriteLine(controller.Tabuleiro.Imprimir());

            
        }
    }
}
