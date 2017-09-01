using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class ServicioAlojamiento: ServicioSalida
    {
        public Ciudad ubicacion { get; set; }
        public int cantEstrella { get; set; }

        public ServicioAlojamiento(int cupo, float precio, ServicioPrestador servicioPrestador, Ciudad ubicacion, int cantEstrella) : base(cupo, precio, servicioPrestador)
        {
            this.ubicacion = ubicacion;
            this.cantEstrella = cantEstrella;
        }
    }
}
