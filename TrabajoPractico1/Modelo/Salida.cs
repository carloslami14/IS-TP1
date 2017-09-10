using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Salida
    {
        public int cupoSalida { get; set; }
        public int numero { get; set; }
        public Tarifa tarifa { get; set; }
        public EstadoSalida estado { get; set; }
        public DateTime fecha { get; set; }
        public Paquete paquete { get; set; }
        public ServicioSalida servicioSalida { get; set; }

        public string _paquete { get { return GetNombrePaquete(); } }
        public string _fecha { get { return GetFecha(); } }
        public string _tarifa { get { return GetTarifa(); } }

        public Salida()
        {
            fecha = DateTime.Now;
        }

        public Salida(Paquete paquete, int cupo, int numero, Tarifa tarifa, EstadoSalida estado, DateTime fecha)
        {
            this.paquete = paquete;
            this.cupoSalida = cupo;
            this.numero = numero;
            this.tarifa = tarifa;
            this.estado = estado;
            this.fecha = fecha;
        }

        public Salida(Paquete paquete, int cupo, int numero, Tarifa tarifa, EstadoSalida estado, DateTime fecha, ServicioSalida servicioSalida)
        {
            this.paquete = paquete;
            this.cupoSalida = cupo;
            this.numero = numero;
            this.tarifa = tarifa;
            this.estado = estado;
            this.fecha = fecha;
            this.servicioSalida = servicioSalida;
        }

        private string GetNombrePaquete()
        {
            return paquete.nombre;
        }

        private string GetFecha()
        {
            return fecha.ToLongDateString();
        }

        private string GetTarifa()
        {
            return tarifa.ToString();
        }
    }
}
