using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico1.Modelo;  //Modelo: Paquete
using TrabajoPractico1.Presentador; //Presentado: PresentadorPaquete
using TrabajoPractico1.Interfaces; //Interfaz: IAgregarPaquete

namespace TrabajoPractico1.Vista
{
    public partial class VAgregarPaquete : Form, IAgregarPaquete
    {
        private PresentadorPaquete _presentador;

        public VAgregarPaquete()
        {
            InitializeComponent();
            _presentador = new PresentadorPaquete(this);
            Iniciar();
        }

        private void Iniciar()
        {
            bindingSource1.DataSource = new Paquete();

            for (int i = 1; i <= 30; i++)
            {
                cbDias.Items.Add(i);
                cbNoches.Items.Add(i);
                cbDesde.Items.Add(i);
                cbHasta.Items.Add(i);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _presentador.AgregarPaquete(); //Falta definir
            this.Dispose();
        }

        public void CargarTablaDestino()
        {
            throw new NotImplementedException();
        }

        public void CargarTablaServicio()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.AgregarDestino(); //Falta definir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.AgregarServicio(); //Falta definir
        }

        private void VAgregarPaquete_Load(object sender, EventArgs e)
        {

        }
    }
}
