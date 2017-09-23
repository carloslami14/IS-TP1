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
        private PresentadorListarPaquetes _presentador;
        private int _estadoPaquete;
        private string _nombrePaquete;

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

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            GuardarPaquete();
        }

        private void cbSeleccionarEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cb = ((ComboBox)sender).SelectedIndex;
            SetEstadoPaquete(cb);
        }

        private void SetEstadoPaquete(int estado)
        {
            this._estadoPaquete = estado;
        }

        private int GetEstadoPaquete()
        {
            return this._estadoPaquete;
        }

        private void SetNombrePaquete(string nombre)
        {
            this._nombrePaquete = nombre;
        }

        private string GetNombrePaquete()
        {
            return this._nombrePaquete;
        }

        private void ModificarPaquete()
        {
            new VAgregarPaquete(_presentador.ModificarPaquete(paqueteBindingSource.Current as Paquete)).Show();
        }

        private void DesactivarPaquete()
        {
            _presentador.DesactivarPaquete(paqueteBindingSource.Current as Paquete);
        }

        private void GuardarPaquete()
        {
            _presentador.GuardarPaquete(GetNombrePaquete(), GetEstadoPaquete());
        }

        public void CargarTabla(List<Paquete> paquete)
        {
            paqueteBindingSource.Clear();
            foreach (Paquete p in paquete)
            {
                paqueteBindingSource.Add(p);
            }
        }
        
        public void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Modificar Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ModificarPaquete(string nombre)
        {
            flpModificarEstado.Controls.Clear();

            SetNombrePaquete(nombre);

            var cbEstados = new ComboBox();
            cbEstados.DataSource = Enum.GetNames(typeof(EstadoPaquete));
            cbEstados.SelectionChangeCommitted += new System.EventHandler(cbSeleccionarEstado_SelectionChangeCommitted);

            var lbEstado = new Label();
            lbEstado.Text = "Estados";

            var lbPaquete = new Label();
            lbPaquete.Text = "Modificar Paquete: ";

            var lbPa = new Label();
            lbPa.Text = nombre;

            var line = new Label();
            line.BorderStyle = BorderStyle.FixedSingle;
            line.Height = 2;
            line.Width = flpModificarEstado.Width;

            var btnCambiar = new Button();
            btnCambiar.TabIndex = 2;
            btnCambiar.Text = "Guardar Estado";
            btnCambiar.Click += new System.EventHandler(btnGuardarEstado_Click);

            flpModificarEstado.Controls.Add(lbPaquete);
            flpModificarEstado.Controls.Add(lbPa);
            flpModificarEstado.Controls.Add(line);
            flpModificarEstado.Controls.Add(lbEstado);
            flpModificarEstado.Controls.Add(cbEstados);
            flpModificarEstado.Controls.Add(btnCambiar);
        }
    }
}
