using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;
using TrabajoPractico1.Modelo;
using TrabajoPractico1.Repositorio;

namespace TrabajoPractico1.Presentador
{
    class PresentadorPaquete
    {
        private readonly IAgregarPaquete _vista;
        private Paquete _paquete;

        public PresentadorPaquete(IAgregarPaquete vista)
        {
            this._vista = vista;
        }

        public void CrearPaquete()
        {
            _paquete = new Paquete();
        }

        public List<Ciudad> GetCiudades()
        {
            return Repositorio.Repositorio.GetCiudades();
        }

        public List<Servicio> GetServicios()
        {
            return Repositorio.Repositorio.GetServicios();
        }

        public List<ServicioPaquete> GetServiciosPaquete()
        {
            return Repositorio.Repositorio.GetServicioPaquete();
        }

        public List<PasoFronterizo> GetPasosFronterizos()
        {
            return Repositorio.Repositorio.GetPasosFronterizos();
        }

        public void AgregarPaquete(Paquete p, List<Ciudad> d, List<ServicioPaquete> s, string origen, List<PasoFronterizo> paso)
        {
            _paquete = p;
            _paquete.AgregarDestinos(d);
            _paquete.estado = EstadoPaquete.Activo;
            _paquete.AgregarServiciosPaquete(s);
            _paquete.AgregarPasoFronterizo(paso);
            _paquete.origen = BuscarCiudad(origen);
            Repositorio.Repositorio.AgregarPaquete(_paquete);
        }

        public void AgregarDestino(string ciudad)
        {
            _vista.ActualizarTablaDestino(BuscarCiudad(ciudad));
        }

        public void AgregarPaso(string paso)
        {
            _vista.ActualizarTablaPasoFronterizo(BuscarPasoFronterizo(paso));
        }

        public void AgregarServicio(string servicio, int desde, int hasta)
        {
            ServicioPaquete ser = new ServicioPaquete(desde, hasta, BuscarServicio(servicio));
            _vista.ActualizarTablaServicio(ser);
        }

        private Ciudad BuscarCiudad(string nombre)
        {
            return Repositorio.Repositorio.BuscarCiudad(nombre);
        }

        private Servicio BuscarServicio(string nombre)
        {
            return Repositorio.Repositorio.BuscarServicio(nombre);
        }

        private PasoFronterizo BuscarPasoFronterizo(string paso)
        {
            return Repositorio.Repositorio.BuscarPasoFronterizo(paso);
        }
    }
}
