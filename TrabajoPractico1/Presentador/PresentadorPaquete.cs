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

        public PresentadorPaquete(Paquete p)
        {
            foreach (Paquete paquete in Repositorio.Repositorio.GetPaquetes())
            {
                if (paquete.Equals(p))
                {
                    _vista.ModificarPaquete(paquete);
                }
            }
        }

        public void CrearNuevoPaquete()
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
            bool bandera = false; //Para saber si es una agregacion o modificacion

            foreach (Paquete pa in Repositorio.Repositorio.GetPaquetes())
            {
                if (pa.codigo == p.codigo)
                {
                    bandera = true;

                    _paquete = p;
                    _paquete.destino = null;
                    _paquete.AgregarDestinos(d);
                    _paquete.estado = EstadoPaquete.Activo;
                    _paquete.serviciosPaquete = null;
                    _paquete.AgregarServiciosPaquete(s);
                    _paquete.pasoFronterizo = null;
                    _paquete.AgregarPasoFronterizo(paso);
                    _paquete.origen = BuscarCiudad(origen);
                }
                else
                {
                    bandera = false;
                }
            }

            if (bandera == false)
            {
                _paquete = p;
                _paquete.codigo = Repositorio.Repositorio.GetPaquetes().Count + 1;
                _paquete.AgregarDestinos(d);
                _paquete.estado = EstadoPaquete.Activo;
                _paquete.AgregarServiciosPaquete(s);
                _paquete.AgregarPasoFronterizo(paso);
                _paquete.origen = BuscarCiudad(origen);
                Repositorio.Repositorio.AgregarPaquete(_paquete);
            }
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
