using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Presentador
{
    class PresentadorListarSalidas
    {
        private readonly IListarSalidas _vista;

        public PresentadorListarSalidas(IListarSalidas vista)
        {
            _vista = vista;
        }

        public void CargarTabla()
        {
            _vista.CargarTabla(Repositorio.Repositorio.GetSalidas());
        }
    }
}
