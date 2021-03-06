﻿using System;
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
    public partial class VAgregarSalida : Form, IAgregarSalida
    {
        private PresentadorSalida _presentador;

        public VAgregarSalida()
        {
            InitializeComponent();
            _presentador = new PresentadorSalida(this);
            _presentador.CrearNuevaSalida();
            Iniciar();
        }

        public VAgregarSalida(Salida s)
        {
            InitializeComponent();
            _presentador = new PresentadorSalida(this);
            Iniciar();
            ModificarSalida(s);
            Show();
        }

        private void Iniciar()
        {
            bindingSource1.DataSource = new Salida();
            bindingSource2.DataSource = new Tarifa();
            cbBase.DataSource = Enum.GetNames(typeof(Base));
            foreach (Paquete e in _presentador.GetPaquetes())
            {
                cbPaquetes.Items.Add(e.nombre);
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarSalida();
            this.Dispose();
        }

        private void GuardarSalida()
        {
            _presentador.AgregarSalida(bindingSource1.Current as Salida, cbPaquetes.Text, bindingSource2.Current as Tarifa);
        }

        private void ModificarSalida(Salida s)
        {
            bindingSource1.Clear();
            bindingSource1.Add(s);

            bindingSource2.Clear();
            bindingSource2.Add(s.tarifa);

            cbPaquetes.Text = s.paquete.nombre;
            cbBase.Tag = s.tarifa.vase;
        }
    }
}
