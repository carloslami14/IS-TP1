using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class PasoFronterizo
    {
        public string nombre { get; set; }
        public Pais pais { get; set; }
        public string _pais { get { return pais.nombre; } }

        public PasoFronterizo(string nombre, Pais pais)
        {
            this.nombre = nombre;
            this.pais = pais;
        }


        public override string ToString()
        {
            return nombre + ", " + pais.nombre;
        }
    }
}
