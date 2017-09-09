using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Presentador
{
    class PresentadorListarPaquetes
    {
        private readonly IListarPaquetes _vista;

        public PresentadorListarPaquetes(IListarPaquetes vista)
        {
            _vista = vista;
        }
    }
}
