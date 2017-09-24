using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Paquete
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string itinerario { get; set; }
        public string cc { get; set; }
        public int cantDias { get; set; }
        public int cantNoches { get; set; }
        public EstadoPaquete estado { get; set; }
        public Ciudad origen { get; set; }
        public List<Ciudad> destino { get; set; }
        public List<ServicioPaquete> serviciosPaquete { get; set; }
        public List<PasoFronterizo> pasoFronterizo { get; set; }

        public Paquete()
        {
            estado = EstadoPaquete.Creado;
        }

        public Paquete(int codigo, string nombre, string descripcion, string itinerario, string cc, int cantDias, int cantNoches, Ciudad origen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.itinerario = itinerario;
            this.cc = cc;
            this.cantDias = cantDias;
            this.cantNoches = cantNoches;
            this.origen = origen;
        }

        public Paquete(int codigo, string nombre, string descripcion, string itinerario, string cc, int cantDias, int cantNoches, Ciudad origen, List<Ciudad> destino, List<ServicioPaquete> servicioPaquete, List<PasoFronterizo> pasoFronterizo)
        {
            this.codigo = codigo;
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

        public void AgregarDestinos(List<Ciudad> destinos)
        {
            this.destino = destinos;
        }

        public void AgregarServiciosPaquete(List<ServicioPaquete> servicios)
        {
            this.serviciosPaquete = servicios;
        }

        public void AgregarPasoFronterizo(List<PasoFronterizo> pasos)
        {
            this.pasoFronterizo = pasos;
        }
    }
}
