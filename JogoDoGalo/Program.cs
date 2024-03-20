using System;

namespace JogoDoGalo
{
    class Program
    {
        static void Main(string[] args)
        {

          Jogador jogador1 = new Jogador();
          Jogador jogador2 = new Jogador();

          Tabuleiro tabuleiro = new Tabuleiro();

          // Controlador com referência ao modelo
          Controller controller = new Controller(jogador1, jogador2, tabuleiro);

          // Vista com referência ao controlador
          View view = new View(controller);

          // Iniciar o programa
          controller.Iniciar(view);
        }
    }
}
