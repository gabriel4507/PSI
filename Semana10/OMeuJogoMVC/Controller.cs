using System;

namespace OMeuJogoMVC
{
    class Controller
    {
        private Inimigo[] inimigos;

      

        public Controller(Inimigo[] inimigos)
        {
          this.inimigos = inimigos;

          
        }   

        public void Iniciar(View view)
        {
          int numInimigos = view.NrInimigos();
          inimigos = new Inimigo[numInimigos];
          
          
        }
      
        
    }
}