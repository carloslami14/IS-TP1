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
            _presentador.CrearNuevoPaquete();
            Iniciar();
        }

        public VAgregarPaquete(Paquete p)
        {
            InitializeComponent();
            _presentador = new PresentadorPaquete(this);
            Iniciar();
            ModificarPaquete(p);
            Show();
        }

        private void Iniciar()
        {
            bindingSource1.DataSource = new Paquete();
            ciudadBindingSource.DataSource = new List<Ciudad>();
            pasoFronterizoBindingSource.DataSource = new List<PasoFronterizo>();
            servicioPaqueteBindingSource.DataSource = new List<ServicioPaquete>();
            CargarListasDesplegables();
        }

        private void CargarListasDesplegables()
        {
            for (int i = 1; i <= 30; i++)
            {
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

            foreach (PasoFronterizo p in _presentador.GetPasosFronterizos())
            {
                cbPasoFronterizo.Items.Add(p.ToString());
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            AgregarPasoFronterizo();
        }

        private void GuardarPaquete()
        {
            _presentador.AgregarPaquete(bindingSource1.Current as Paquete, ciudadBindingSource.List as List<Ciudad>, servicioPaqueteBindingSource.List as List<ServicioPaquete>, cbOrigen.SelectedItem.ToString().Split(',')[0], pasoFronterizoBindingSource.List as List<PasoFronterizo>);
        }

        private void AgregarDestino()
        {
            _presentador.AgregarDestino(cbDestino.SelectedItem.ToString().Split(',')[0]);
        }

        private void AgregarServicio()
        {
            _presentador.AgregarServicio(cbServicio.SelectedItem.ToString().Split(',')[0], int.Parse(cbDesde.SelectedItem.ToString()), int.Parse(cbHasta.SelectedItem.ToString()));
        }

        private void AgregarPasoFronterizo()
        {
            _presentador.AgregarPaso(cbPasoFronterizo.SelectedItem.ToString().Split(',')[0]);
        }

        public void ActualizarTablaDestino(Ciudad c)
        {
            ciudadBindingSource.Add(c);
        }

        public void ActualizarTablaServicio(ServicioPaquete s)
        {
            servicioPaqueteBindingSource.Add(s);
        }

        public void ActualizarTablaPasoFronterizo(PasoFronterizo p)
        {
            pasoFronterizoBindingSource.Add(p);
        }

        public void ModificarPaquete(Paquete p)
        {
            bindingSource1.Clear();
            bindingSource1.Add(p);

            cbOrigen.Text = p.origen.ToString();

            pasoFronterizoBindingSource.Clear();
            List<PasoFronterizo> pasos = p.pasoFronterizo;
            for (int i=0; i<pasos.Count; i++)
            {
                pasoFronterizoBindingSource.Add(pasos[i]);
            }

            servicioPaqueteBindingSource.Clear();
            List<ServicioPaquete> servicios = p.serviciosPaquete;
            for (int i = 0; i < servicios.Count; i++)
            {
                servicioPaqueteBindingSource.Add(servicios[i]);
            }

            ciudadBindingSource.Clear();
            List<Ciudad> destinos = p.destino;
            for (int i = 0; i < destinos.Count; i++)
            {
                ciudadBindingSource.Add(destinos[i]);
            }
        }
    }
}
