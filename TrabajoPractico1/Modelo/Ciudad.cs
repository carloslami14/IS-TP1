using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class Ciudad
    {
        public string nombre { get; set; }
        public Provincia provincia { get; set; }
        public Pais pais { get; set; }

        public Ciudad(string nombre, Provincia provincia, Pais pais)
        {
            this.nombre = nombre;
            this.provincia = provincia;
            this.pais = pais;
        }
    }
}
