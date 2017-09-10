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
    public partial class VListarPaquetes : Form, IListarPaquetes
    {
        PresentadorListarPaquetes _presentador;

        public VListarPaquetes()
        {
            InitializeComponent();
            _presentador = new PresentadorListarPaquetes(this);
            Iniciar();
        }

        private void Iniciar()
        {
            paqueteBindingSource.DataSource = new Paquete();
            _presentador.CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarPaquete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesactivarPaquete();
        }

        private void ModificarPaquete()
        {
            _presentador.ModificarPaquete(paqueteBindingSource.Current as Paquete);
        }

        public void CargarTabla(List<Paquete> paquete)
        {
            paqueteBindingSource.Clear();
            foreach (Paquete p in paquete)
            {
                paqueteBindingSource.Add(p);
            }
        }

        private void DesactivarPaquete()
        {
            _presentador.DesactivarPaquete(paqueteBindingSource.Current as Paquete);
        }

        public void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Modificar Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
