using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public void MaxRecomendado() 
        {
            Console.WriteLine("El máximo permitido de una cerveza son 10");
        }
        //public Cerveza() : base("Cerveza", 560)
        public Cerveza(string Nombre ,int Cantidad=55) : base(Nombre, Cantidad)
        {

        }

    }
}
