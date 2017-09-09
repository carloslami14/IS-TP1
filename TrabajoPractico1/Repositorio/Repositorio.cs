using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Repositorio
{
    class Repositorio
    {
        private static List<Paquete> _paquetes;
        private static List<Ciudad> _ciudades;
        private static List<Servicio> _servicios;
        private static List<ServicioPaquete> _serviciosPaquete;

        public Repositorio()
        {
            _paquetes = new List<Paquete>();
            _ciudades = new List<Ciudad>();
            _servicios = new List<Servicio>();
            _serviciosPaquete = new List<ServicioPaquete>();
            GenerarDatos();
        }

        public void AgregarPaquete(Paquete p)
        {
            _paquetes.Add(p);
        }

        private static void GenerarDatos()
        {
            Pais pais1 = new Pais("Argentina");

            Provincia p1 = new Provincia("Tucuman", pais1);
            Provincia p2 = new Provincia("Salta", pais1);

            Ciudad c1 = new Ciudad("Tafi del Valle", p1);
            Ciudad c2 = new Ciudad("Metan", p2);

            pais1.AgregarProvincia(p1);
            pais1.AgregarProvincia(p2);

            p1.AgregarCiudades(c1);
            p2.AgregarCiudades(c2);

            _ciudades.Add(c1);
            _ciudades.Add(c2);

            Tipo t1 = new Tipo("Omnibus", Rubro.Transporte);
            Tipo t2 = new Tipo("Hotel", Rubro.Alojamiento);

            Servicio s1 = new Servicio("Noche de Hotel", t2);
            Servicio s2 = new Servicio("Butaca", t1);

            _servicios.Add(s1);
            _servicios.Add(s2);
        }

        public List<Ciudad> GetCiudades()
        {
            return _ciudades;
        }

        public List<Servicio> GetServicios()
        {
            return _servicios;
        }

        public List<ServicioPaquete> GetServicioPaquete()
        {
            return _serviciosPaquete;
        }

        public Ciudad BuscarCiudad(string ciudad)
        {

            foreach (Ciudad c in _ciudades)
            {
                if (ciudad == c.nombre)
                {
                    return c;
                }
            }

            return null;
        }

        public Servicio BuscarServicio(string ciudad)
        {

            foreach (Servicio c in _servicios)
            {
                if (ciudad == c.nombre)
                {
                    return c;
                }
            }

            return null;
        }
    }
}
