using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class ServicioPrestador
    {
        public string nombre { get; set; }
        public Prestador prestador { get; set; }

        public ServicioPrestador(string nombre, Prestador prestador)
        {
            this.nombre = nombre;
            this.prestador = prestador;
        }
    }
}
