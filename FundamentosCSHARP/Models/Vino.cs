using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 3 copas");
        }
        //public Cerveza() : base("Cerveza", 560)
        public Vino(string Nombre="Vino", int Cantidad=300) : base(Nombre, Cantidad)
        {

        }

    }
}
