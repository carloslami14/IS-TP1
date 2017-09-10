using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Repositorio
{
    static class Repositorio
    {
        private static List<Paquete> _paquetes;
        private static List<Ciudad> _ciudades;
        private static List<Servicio> _servicios;
        private static List<ServicioPaquete> _serviciosPaquete;
        private static List<Salida> _salidas;
        private static List<PasoFronterizo> _pasosFronterizos;

        public static void Inicio()
        {
            _paquetes = new List<Paquete>();
            _ciudades = new List<Ciudad>();
            _servicios = new List<Servicio>();
            _serviciosPaquete = new List<ServicioPaquete>();
            _salidas = new List<Salida>();
            _pasosFronterizos = new List<PasoFronterizo>();
            GenerarDatos();

        }

        public static void AgregarPaquete(Paquete p)
        {
            _paquetes.Add(p);
        }

        public static void AgregarSalida(Salida s)
        {
            _salidas.Add(s);
        }

        private static void GenerarDatos()
        {
            Pais pais1 = new Pais("Argentina");

            Provincia p1 = new Provincia("Tucuman", pais1);
            Provincia p2 = new Provincia("Salta", pais1);

            Ciudad c1 = new Ciudad("Tafi del Valle", p1);
            Ciudad c2 = new Ciudad("Metan", p2);

            PasoFronterizo paso1 = new PasoFronterizo("Paso 1", pais1);
            PasoFronterizo paso2 = new PasoFronterizo("Paso 2", pais1);

            _pasosFronterizos.Add(paso1);
            _pasosFronterizos.Add(paso2);

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

            Paquete paquete1 = new Paquete("Paquete1", "des", "itien", "cc", 2, 4, c1);

            _paquetes.Add(paquete1);

            Tarifa ta1 = new Tarifa(22, Base.Cuadruple);
            DateTime data = new DateTime();

            Salida salida1 = new Salida(paquete1, 12,1,ta1, EstadoSalida.Creada, data);

            _salidas.Add(salida1);
        }

        public static List<Paquete> GetPaquetes()
        {
            return _paquetes;
        }

        public static List<Salida> GetSalidas()
        {
            return _salidas;
        }

        public static List<Ciudad> GetCiudades()
        {
            return _ciudades;
        }

        public static List<Servicio> GetServicios()
        {
            return _servicios;
        }

        public static List<ServicioPaquete> GetServicioPaquete()
        {
            return _serviciosPaquete;
        }

        public static List<PasoFronterizo> GetPasosFronterizos()
        {
            return _pasosFronterizos;
        }

        public static Ciudad BuscarCiudad(string ciudad)
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

        public static Servicio BuscarServicio(string ciudad)
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

        public static Paquete BuscarPaquete(string paquete)
        {
            foreach (Paquete p in _paquetes)
            {
                if (paquete == p.nombre)
                {
                    return p;
                }
            }
            return null;
        }

        public static PasoFronterizo BuscarPasoFronterizo(string paso)
        {
            foreach (PasoFronterizo p in _pasosFronterizos)
            {
                if (paso == p.nombre)
                {
                    return p;
                }
                  
            }
            return null;
        }
    }
}
