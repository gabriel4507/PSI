using System;

namespace JogoDoGalo
{
    class Controller
    {
        private View view;

        private Jogador jogador1;
        private Jogador jogador2;

        private Tabuleiro tabuleiro;

        public Controller(Jogador jogador1, Jogador jogador2, Tabuleiro tabuleiro)
      {
        this.jogador1 = jogador1;
        this.jogador2 = jogador2;

        this.tabuleiro = tabuleiro;
      }

        public void IniciarJogo(Viev view)
      {
        this.view = view;

        view.Inciar();
        
      }
      
    }
}
