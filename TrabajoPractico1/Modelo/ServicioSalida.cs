using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class ServicioSalida
    {
        public int cupo { get; set; }
        public float precio { get; set; }
        public ServicioPrestador servicioPrestador { get; set; }

        public ServicioSalida(int cupo, float precio, ServicioPrestador servicioPrestador)
        {
            this.cupo = cupo;
            this.precio = precio;
            this.servicioPrestador = servicioPrestador;
        }
    }
}
