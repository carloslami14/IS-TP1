using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico1.Modelo;
using TrabajoPractico1.Presentador;
using TrabajoPractico1.Interfaces;

namespace TrabajoPractico1.Vista
{
    public partial class VAgregarPaquete : Form, IAgregarPaquete
    {
        private PresentadorPaquete _presentador;

        public VAgregarPaquete()
        {
            InitializeComponent();
            _presentador = new PresentadorPaquete(this);
            _presentador.CrearPaquete();
            Iniciar();
        }

        private void Iniciar()
        {
            bindingSource1.DataSource = new Paquete();
            ciudadBindingSource.DataSource = new List<Ciudad>();
            serviciosPaqueteBindingSource.DataSource = new List<ServicioPaquete>();
            CargarListasDesplegables();
        }

        private void CargarListasDesplegables()
        {
            for (int i = 1; i <= 30; i++)
            {
                cbDias.Items.Add(i);
                cbNoches.Items.Add(i);
                cbDesde.Items.Add(i);
                cbHasta.Items.Add(i);
            }

            foreach (Ciudad c in _presentador.GetCiudades())
            {
                cbDestino.Items.Add(c.ToString());
                cbOrigen.Items.Add(c.ToString());
            }

            foreach (Servicio s in _presentador.GetServicios())
            {
                cbServicio.Items.Add(s.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPaquete();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDestino();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarServicio();
        }

        private void GuardarPaquete()
        {
            _presentador.AgregarPaquete(bindingSource1.Current as Paquete, ciudadBindingSource.List as List<Ciudad>, serviciosPaqueteBindingSource.List as List<ServicioPaquete>, cbOrigen.SelectedItem.ToString().Split(',')[0]);
        }

        private void AgregarDestino()
        {
            string ciudad = cbDestino.SelectedItem.ToString().Split(',')[0];
            _presentador.AgregarDestino(ciudad);
        }

        private void AgregarServicio()
        {
            string servicio = cbServicio.SelectedItem.ToString().Split(',')[0];
            _presentador.AgregarServicio(servicio, int.Parse(cbDesde.SelectedItem.ToString()), int.Parse(cbHasta.SelectedItem.ToString()));
        }

        public void ActualizarTablaDestino(Ciudad c)
        {
            ciudadBindingSource.Add(c);
        }

        public void ActualizarTablaServicio(ServicioPaquete s)
        {
            serviciosPaqueteBindingSource.Add(s);
        }
    }
}
