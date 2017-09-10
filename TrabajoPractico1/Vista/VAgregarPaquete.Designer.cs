namespace TrabajoPractico1.Vista
{
    partial class VAgregarPaquete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregarDestino = new System.Windows.Forms.Button();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDesde = new System.Windows.Forms.ComboBox();
            this.cbHasta = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnQuitarDestino = new System.Windows.Forms.Button();
            this.btnQuitarServicio = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPasoFronterizo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasoFronterizoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregarPasoFronterizo = new System.Windows.Forms.Button();
            this.btnQuitarPasoFronterizo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.servicioPaqueteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasoFronterizoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioPaqueteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(217, 300);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarServicio.TabIndex = 51;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Hasta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Desde";
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(96, 205);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(196, 21);
            this.cbServicio.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Servicio";
            // 
            // tbDestino
            // 
            this.tbDestino.AutoGenerateColumns = false;
            this.tbDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn1,
            this.paisDataGridViewTextBoxColumn});
            this.tbDestino.DataSource = this.ciudadBindingSource;
            this.tbDestino.Location = new System.Drawing.Point(385, 364);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(354, 116);
            this.tbDestino.TabIndex = 43;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn1
            // 
            this.provinciaDataGridViewTextBoxColumn1.DataPropertyName = "_provincia";
            this.provinciaDataGridViewTextBoxColumn1.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn1.Name = "provinciaDataGridViewTextBoxColumn1";
            this.provinciaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "_pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataSource = typeof(TrabajoPractico1.Modelo.Ciudad);
            // 
            // btnAgregarDestino
            // 
            this.btnAgregarDestino.Location = new System.Drawing.Point(217, 476);
            this.btnAgregarDestino.Name = "btnAgregarDestino";
            this.btnAgregarDestino.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDestino.TabIndex = 42;
            this.btnAgregarDestino.Text = "Agregar";
            this.btnAgregarDestino.UseVisualStyleBackColor = true;
            this.btnAgregarDestino.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(115, 434);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(219, 21);
            this.cbDestino.TabIndex = 41;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(356, -34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 21);
            this.comboBox3.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ciudad Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, -31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ciudad Origen";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "itinerario", true));
            this.textBox4.Location = new System.Drawing.Point(417, 77);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(340, 45);
            this.textBox4.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Itinerario";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cc", true));
            this.textBox3.Location = new System.Drawing.Point(417, 128);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 53);
            this.textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "descripcion", true));
            this.textBox2.Location = new System.Drawing.Point(417, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 44);
            this.textBox2.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Condicion Comercial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cantidad de Noches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cantidad de Dias";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, -31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(115, 376);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(219, 21);
            this.cbOrigen.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Ciudad Origen";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nombre", true));
            this.textBox7.Location = new System.Drawing.Point(96, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Nombre";
            // 
            // cbDesde
            // 
            this.cbDesde.FormattingEnabled = true;
            this.cbDesde.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5"});
            this.cbDesde.Location = new System.Drawing.Point(96, 254);
            this.cbDesde.Name = "cbDesde";
            this.cbDesde.Size = new System.Drawing.Size(51, 21);
            this.cbDesde.TabIndex = 56;
            // 
            // cbHasta
            // 
            this.cbHasta.FormattingEnabled = true;
            this.cbHasta.Location = new System.Drawing.Point(241, 254);
            this.cbHasta.Name = "cbHasta";
            this.cbHasta.Size = new System.Drawing.Size(51, 21);
            this.cbHasta.TabIndex = 57;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(664, 651);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(543, 651);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnQuitarDestino
            // 
            this.btnQuitarDestino.Location = new System.Drawing.Point(105, 476);
            this.btnQuitarDestino.Name = "btnQuitarDestino";
            this.btnQuitarDestino.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarDestino.TabIndex = 60;
            this.btnQuitarDestino.Text = "Quitar";
            this.btnQuitarDestino.UseVisualStyleBackColor = true;
            // 
            // btnQuitarServicio
            // 
            this.btnQuitarServicio.Location = new System.Drawing.Point(105, 300);
            this.btnQuitarServicio.Name = "btnQuitarServicio";
            this.btnQuitarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarServicio.TabIndex = 61;
            this.btnQuitarServicio.Text = "Quitar";
            this.btnQuitarServicio.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 535);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Paso Fronterizo";
            // 
            // cbPasoFronterizo
            // 
            this.cbPasoFronterizo.FormattingEnabled = true;
            this.cbPasoFronterizo.Location = new System.Drawing.Point(115, 537);
            this.cbPasoFronterizo.Name = "cbPasoFronterizo";
            this.cbPasoFronterizo.Size = new System.Drawing.Size(219, 21);
            this.cbPasoFronterizo.TabIndex = 63;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.paisDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.pasoFronterizoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(385, 535);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 97);
            this.dataGridView1.TabIndex = 64;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // paisDataGridViewTextBoxColumn1
            // 
            this.paisDataGridViewTextBoxColumn1.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn1.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn1.Name = "paisDataGridViewTextBoxColumn1";
            // 
            // pasoFronterizoBindingSource
            // 
            this.pasoFronterizoBindingSource.DataSource = typeof(TrabajoPractico1.Modelo.PasoFronterizo);
            // 
            // btnAgregarPasoFronterizo
            // 
            this.btnAgregarPasoFronterizo.Location = new System.Drawing.Point(217, 589);
            this.btnAgregarPasoFronterizo.Name = "btnAgregarPasoFronterizo";
            this.btnAgregarPasoFronterizo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPasoFronterizo.TabIndex = 65;
            this.btnAgregarPasoFronterizo.Text = "Agregar";
            this.btnAgregarPasoFronterizo.UseVisualStyleBackColor = true;
            this.btnAgregarPasoFronterizo.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnQuitarPasoFronterizo
            // 
            this.btnQuitarPasoFronterizo.Location = new System.Drawing.Point(105, 589);
            this.btnQuitarPasoFronterizo.Name = "btnQuitarPasoFronterizo";
            this.btnQuitarPasoFronterizo.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarPasoFronterizo.TabIndex = 66;
            this.btnQuitarPasoFronterizo.Text = "Quitar";
            this.btnQuitarPasoFronterizo.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(TrabajoPractico1.Modelo.Paquete);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desdeDataGridViewTextBoxColumn,
            this.hastaDataGridViewTextBoxColumn,
            this.servicioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.servicioPaqueteBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(385, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(354, 116);
            this.dataGridView2.TabIndex = 67;
            // 
            // servicioPaqueteBindingSource
            // 
            this.servicioPaqueteBindingSource.DataSource = typeof(TrabajoPractico1.Modelo.ServicioPaquete);
            // 
            // desdeDataGridViewTextBoxColumn
            // 
            this.desdeDataGridViewTextBoxColumn.DataPropertyName = "desde";
            this.desdeDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.desdeDataGridViewTextBoxColumn.Name = "desdeDataGridViewTextBoxColumn";
            // 
            // hastaDataGridViewTextBoxColumn
            // 
            this.hastaDataGridViewTextBoxColumn.DataPropertyName = "hasta";
            this.hastaDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.hastaDataGridViewTextBoxColumn.Name = "hastaDataGridViewTextBoxColumn";
            // 
            // servicioDataGridViewTextBoxColumn
            // 
            this.servicioDataGridViewTextBoxColumn.DataPropertyName = "servicio";
            this.servicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.servicioDataGridViewTextBoxColumn.Name = "servicioDataGridViewTextBoxColumn";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cantDias", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox5.Location = new System.Drawing.Point(144, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 68;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cantNoches", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox6.Location = new System.Drawing.Point(144, 109);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 69;
            // 
            // VAgregarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 683);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnQuitarPasoFronterizo);
            this.Controls.Add(this.btnAgregarPasoFronterizo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbPasoFronterizo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnQuitarServicio);
            this.Controls.Add(this.btnQuitarDestino);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbHasta);
            this.Controls.Add(this.cbDesde);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.btnAgregarDestino);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "VAgregarPaquete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Paquete";
            ((System.ComponentModel.ISupportInitialize)(this.tbDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasoFronterizoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioPaqueteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tbDestino;
        private System.Windows.Forms.Button btnAgregarDestino;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbDesde;
        private System.Windows.Forms.ComboBox cbHasta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnQuitarDestino;
        private System.Windows.Forms.Button btnQuitarServicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPasoFronterizo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource pasoFronterizoBindingSource;
        private System.Windows.Forms.Button btnAgregarPasoFronterizo;
        private System.Windows.Forms.Button btnQuitarPasoFronterizo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servicioPaqueteBindingSource;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}