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
        private int _contador = 0;

        public PresentadorSalida(IAgregarSalida vista)
        {
            this._vista = vista;
        }

        private void Contador()
        {
            _contador++;
        }

        public void CrearSalida()
        {
            _salida = new Salida();
        }

        public void GuardarSalida(Salida salida, string paquete, Tarifa tar)
        {
            _salida = salida;
            _salida.numero = Repositorio.Repositorio.GetSalidas().Count + 1;
            _salida.paquete = BuscarPaquete(paquete);
            _salida.tarifa = tar;
            _salida.estado = EstadoSalida.Creada;
            Repositorio.Repositorio.AgregarSalida(_salida);
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
