using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class PasoFronterizo
    {
        public string nombre { get; set; }
        public Pais pais { get; set; }

        public PasoFronterizo(string nombre, Pais pais)
        {
            this.nombre = nombre;
            this.pais = pais;
        }
    }
}
