using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Presentador
{
    class PresentadorPaquete
    {
        private readonly IAgregarPaquete _vista;

        public PresentadorPaquete(IAgregarPaquete vista)
        {
            this._vista = vista;
        }

        public void AgregarPaquete()
        {

        }

        public void AgregarDestino()
        {

        }

        public void AgregarServicio()
        {

        }
    }
}
