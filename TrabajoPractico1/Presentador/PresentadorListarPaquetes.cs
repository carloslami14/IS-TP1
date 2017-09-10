using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Presentador
{
    class PresentadorListarPaquetes
    {
        private readonly IListarPaquetes _vista;

        public PresentadorListarPaquetes(IListarPaquetes vista)
        {
            _vista = vista;
        }

        public void CargarTabla()
        {
            _vista.CargarTabla(Repositorio.Repositorio.GetPaquetes());
        }

        public void ModificarPaquete(Paquete p)
        {

        }
    }
}
