using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    internal class Cerveza : Bebida
    {
        //public Cerveza() : base("Cerveza", 560)
        public Cerveza(string Nombre ,int Cantidad=55) : base(Nombre, Cantidad)
        {

        }
    }
}
