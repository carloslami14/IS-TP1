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
        private Repositorio.Repositorio _repositorio;

        public PresentadorPaquete(IAgregarPaquete vista)
        {
            this._vista = vista;
            _repositorio = new Repositorio.Repositorio();
        }

        public void CrearPaquete()
        {
            _paquete = new Paquete();
        }

        public List<Ciudad> GetCiudades()
        {
            return _repositorio.GetCiudades();
        }

        public List<Servicio> GetServicios()
        {
            return _repositorio.GetServicios();
        }

        public List<ServicioPaquete> GetServiciosPaquete()
        {
            return _repositorio.GetServicioPaquete();
        }

        public void AgregarPaquete(Paquete p, List<Ciudad> d, List<ServicioPaquete> s, string origen)
        {
            _paquete = p;
            _paquete.AgregarDestinos(d);
            _paquete.AgregarServiciosPaquete(s);
            _paquete.origen = BuscarCiudad(origen);
            _repositorio.AgregarPaquete(_paquete);
        }

        public void AgregarDestino(string ciudad)
        {
            Ciudad c = BuscarCiudad(ciudad);
            _vista.ActualizarTablaDestino(c);
        }

        public void AgregarServicio(string servicio, int desde, int hasta)
        {
            Servicio s = BuscarServicio(servicio);
            ServicioPaquete ser = new ServicioPaquete(desde, hasta, s);
            _vista.ActualizarTablaServicio(ser);
        }

        private Ciudad BuscarCiudad(string nombre)
        {
            return _repositorio.BuscarCiudad(nombre);
        }

        private Servicio BuscarServicio(string nombre)
        {
            return _repositorio.BuscarServicio(nombre);
        }
    }
}
