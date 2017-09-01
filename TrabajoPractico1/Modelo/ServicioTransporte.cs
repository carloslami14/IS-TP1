using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class ServicioTransporte : ServicioSalida
    {
        public Ciudad origen { get; set; }
        public List<Ciudad> destino { get; set; }

        public ServicioTransporte(int cupo, float precio, ServicioPrestador servicioPrestador, Ciudad origen, List<Ciudad> destino) : base(cupo, precio, servicioPrestador)
        {
            this.origen = origen;
            this.destino = destino;
        }

        public void AgregarDestino(Ciudad ciudad)
        {
            this.destino.Add(ciudad);
        }
    }
}
