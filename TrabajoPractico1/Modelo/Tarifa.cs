using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Tarifa
    {
        public float precio { get; set; }
        public Base vase { get; set; }

        public Tarifa() { }

        public Tarifa(float precio, Base vase)
        {
            this.precio = precio;
            this.vase = vase;
        }

        public override string ToString()
        {
            return "$" + precio + "," + vase;
        }
    }
}
