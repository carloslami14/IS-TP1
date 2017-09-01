using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico1.Interfaces;
using TrabajoPractico1.Presentador;

namespace TrabajoPractico1.Vista
{
    public partial class VInicio : Form, IInicio
    {
        private PresentadorInicio _presentador;

        public VInicio()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            _presentador = new PresentadorInicio(this);
        }

        public void MostrarNuevoPaquete()
        {

        }

        public void MostrarListarPaquetes()
        {

        }

        public void MostrarNuevaSalida()
        {

        }

        public void MostrarListarSalidas()
        {

        }
    }
}
