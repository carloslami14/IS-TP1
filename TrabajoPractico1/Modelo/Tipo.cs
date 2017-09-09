using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Tipo
    {
        public string tipo { get; set; }
        public Rubro rubro { get; set; }

        public Tipo(string tipo, Rubro rubro)
        {
            this.tipo = tipo;
            this.rubro = rubro;
        }
    }
}
