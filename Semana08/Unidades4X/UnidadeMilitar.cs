using System;

namespace Unidades4X
{
    public class UnidadeMilitar : Unidade
    {
        public override int Vida{ get => base.Vida + XP; }
        public int PoderAtaque { get; set; }
        public int XP { get; set; }
        public override float Valor { get => PoderAtaque + XP;}

        public UnidadeMilitar(int mov,  int vida, int pa) : base(mov, vida)
        {
  
            PoderAtaque = pa;
            XP = 0;
        }


        public override string ToString()
        {
            return base.ToString + " Poder de ataque: " + PoderAtaque + " XP: " + XP;

        }

        public void Atacar(Unidade u)
        {
            Console.WriteLine($"Unidade atacou {u} com dano {PoderAtaque}");
        }
    }
}
