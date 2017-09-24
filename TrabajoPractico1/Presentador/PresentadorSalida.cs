using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;
using TrabajoPractico1.Repositorio;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Presentador
{
    class PresentadorSalida
    {
        private readonly IAgregarSalida _vista;
        private Salida _salida;

        public PresentadorSalida(IAgregarSalida vista)
        {
            this._vista = vista;
        }

        public void CrearNuevaSalida()
        {
            _salida = new Salida();
            _salida.estado = EstadoSalida.Creada;
        }

        public void AgregarSalida(Salida salida, string paquete, Tarifa tar)
        {
            bool bandera = false;

            foreach (Salida s in Repositorio.Repositorio.GetSalidas())
            {
                if (s.numero == salida.numero)
                {
                    bandera = true;

                    _salida = salida;
                    _salida.paquete = BuscarPaquete(paquete);
                    _salida.tarifa = tar;
                    _salida.estado = EstadoSalida.EnVenta;
                }
            }

            if (bandera == false)
            {
                _salida = salida;
                _salida.numero = Repositorio.Repositorio.GetSalidas().Count + 1;
                _salida.paquete = BuscarPaquete(paquete);
                _salida.tarifa = tar;
                _salida.estado = EstadoSalida.EnVenta;
                Repositorio.Repositorio.AgregarSalida(_salida);
            }
        }

        public List<Paquete> GetPaquetes()
        {
            return Repositorio.Repositorio.GetPaquetes();
        }

        private Paquete BuscarPaquete(string pa)
        {
            return Repositorio.Repositorio.BuscarPaquete(pa);
        }
    }
}
