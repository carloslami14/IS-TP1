using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class ServicioPaquete
    {
        public int desde { get; set; }
        public int hasta { get; set; }
        public Servicio servicio { get; set; }

        public ServicioPaquete(int desde, int hasta, Servicio servicio)
        {
            this.desde = desde;
            this.hasta = hasta;
            this.servicio = servicio;
        }
    }
}
