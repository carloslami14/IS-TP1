using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico1.Presentador;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Vista
{
    public partial class VListarPaquetes : Form, IListarPaquetes
    {
        PresentadorListarPaquetes _presentador;

        public VListarPaquetes()
        {
            InitializeComponent();
            _presentador = new PresentadorListarPaquetes(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
