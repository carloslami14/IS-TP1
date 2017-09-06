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

        private void Iniciar()
        {
            _presentador = new PresentadorInicio(this);
        }

        public void MostrarNuevoPaquete()
        {
            new VAgregarPaquete().Show();
        }

        public void MostrarListarPaquetes()
        {
            new VListarPaquetes().Show();
        }

        public void MostrarNuevaSalida()
        {
            new VAgregarSalida().Show();
        }

        public void MostrarListarSalidas()
        {
            new VListarSalidas().Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarNuevoPaquete();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListarPaquetes();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarNuevaSalida();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarListarSalidas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
