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
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Vista
{
    public partial class VListarSalidas : Form, IListarSalidas
    {
        private PresentadorListarSalidas _presentador;

        public VListarSalidas()
        {
            InitializeComponent();
            Iniciar();
            _presentador = new PresentadorListarSalidas(this);
            _presentador.CargarTabla();
        }

        private void Iniciar()
        {
            salidaBindingSource.DataSource = new Salida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DesactivarPaquete();
        }

        private void DesactivarPaquete()
        {
            _presentador.DesactivarSalida(salidaBindingSource.Current as Salida);
        }

        public void CargarTabla(List<Salida> salidas)
        {
            salidaBindingSource.Clear();
            foreach (Salida s in salidas)
            {
                salidaBindingSource.Add(s);
            }
        }

        public void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Modificar Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
