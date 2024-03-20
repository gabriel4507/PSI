using System;

namespace OMeuJogoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimigo[] inimigos;

            Controller controller = new Controller(inimigos);

            View view = new View(controller);

            contoller.Iniciar(view);
          
        }
    }
}
