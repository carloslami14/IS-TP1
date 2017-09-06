namespace TrabajoPractico1.Vista
{
    partial class VListarPaquetes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.paqueteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itinerarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantNochesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.itinerarioDataGridViewTextBoxColumn,
            this.ccDataGridViewTextBoxColumn,
            this.cantDiasDataGridViewTextBoxColumn,
            this.cantNochesDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paqueteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Paquetes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar Estado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Modificar Paquete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // paqueteBindingSource
            // 
            this.paqueteBindingSource.DataSource = typeof(TrabajoPractico1.Modelo.Paquete);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // itinerarioDataGridViewTextBoxColumn
            // 
            this.itinerarioDataGridViewTextBoxColumn.DataPropertyName = "itinerario";
            this.itinerarioDataGridViewTextBoxColumn.HeaderText = "Itinerario";
            this.itinerarioDataGridViewTextBoxColumn.Name = "itinerarioDataGridViewTextBoxColumn";
            // 
            // ccDataGridViewTextBoxColumn
            // 
            this.ccDataGridViewTextBoxColumn.DataPropertyName = "cc";
            this.ccDataGridViewTextBoxColumn.HeaderText = "CC";
            this.ccDataGridViewTextBoxColumn.Name = "ccDataGridViewTextBoxColumn";
            // 
            // cantDiasDataGridViewTextBoxColumn
            // 
            this.cantDiasDataGridViewTextBoxColumn.DataPropertyName = "cantDias";
            this.cantDiasDataGridViewTextBoxColumn.HeaderText = "Cantidad Dias";
            this.cantDiasDataGridViewTextBoxColumn.Name = "cantDiasDataGridViewTextBoxColumn";
            // 
            // cantNochesDataGridViewTextBoxColumn
            // 
            this.cantNochesDataGridViewTextBoxColumn.DataPropertyName = "cantNoches";
            this.cantNochesDataGridViewTextBoxColumn.HeaderText = "Cantidad Noches";
            this.cantNochesDataGridViewTextBoxColumn.Name = "cantNochesDataGridViewTextBoxColumn";
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            // 
            // VListarPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VListarPaquetes";
            this.ShowIcon = false;
            this.Text = "Lista de Paquetes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itinerarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantNochesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paqueteBindingSource;
    }
}