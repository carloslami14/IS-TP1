using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    class Paquete
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string itinerario { get; set; }
        public string cc { get; set; }
        public int cantDias { get; set; }
        public int cantNoches { get; set; }
        public Ciudad origen { get; set; }
        public List<Ciudad> destino { get; set; }
        public List<ServicioPaquete> serviciosPaquete { get; set; }
        public List<PasoFronterizo> pasoFronterizo { get; set; }

        public Paquete() { }

        public Paquete(string nombre, string descripcion, string itinerario, string cc, int cantDias, int cantNoches, Ciudad origen, List<Ciudad> destino, List<ServicioPaquete> servicioPaquete, List<PasoFronterizo> pasoFronterizo)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.itinerario = itinerario;
            this.cc = cc;
            this.cantDias = cantDias;
            this.cantNoches = cantNoches;
            this.origen = origen;
            this.destino = destino;
            this.serviciosPaquete = serviciosPaquete;
            this.pasoFronterizo = pasoFronterizo;
        }

        public void AgregarDestino(Ciudad ciudad)
        {
            this.destino.Add(ciudad);
        }

        public void AgregarServicioPaquete(ServicioPaquete servicio)
        {
            this.serviciosPaquete.Add(servicio);
        }

        public void AgregarPasoFronterizo(PasoFronterizo paso)
        {
            this.pasoFronterizo.Add(paso);
        }
    }
}
