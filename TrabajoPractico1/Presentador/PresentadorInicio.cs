using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Presentador
{
    class PresentadorInicio
    {
        private readonly IInicio _vista;

        public PresentadorInicio(IInicio vista)
        {
            this._vista = vista;
        }
    }
}
