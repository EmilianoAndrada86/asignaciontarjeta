namespace EP1_POO_EmilianoAndrada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nroTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaOtorgamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPesosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nroTarjetaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaOtorgamientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTarjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTarjetaDataGridViewTextBoxColumn,
            this.fechaOtorgamientoDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.tipoTarjetaDataGridViewTextBoxColumn,
            this.saldoPesosDataGridViewTextBoxColumn,
            this.saldoDolaresDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vistaTarjetaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(648, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(682, 192);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nroTarjetaDataGridViewTextBoxColumn
            // 
            this.nroTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NroTarjeta";
            this.nroTarjetaDataGridViewTextBoxColumn.HeaderText = "Numero Tarjeta";
            this.nroTarjetaDataGridViewTextBoxColumn.Name = "nroTarjetaDataGridViewTextBoxColumn";
            // 
            // fechaOtorgamientoDataGridViewTextBoxColumn
            // 
            this.fechaOtorgamientoDataGridViewTextBoxColumn.DataPropertyName = "FechaOtorgamiento";
            this.fechaOtorgamientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Otorgamiento";
            this.fechaOtorgamientoDataGridViewTextBoxColumn.Name = "fechaOtorgamientoDataGridViewTextBoxColumn";
            this.fechaOtorgamientoDataGridViewTextBoxColumn.Width = 120;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            // 
            // tipoTarjetaDataGridViewTextBoxColumn
            // 
            this.tipoTarjetaDataGridViewTextBoxColumn.DataPropertyName = "tipoTarjeta";
            this.tipoTarjetaDataGridViewTextBoxColumn.HeaderText = "Tipo Tarjeta";
            this.tipoTarjetaDataGridViewTextBoxColumn.Name = "tipoTarjetaDataGridViewTextBoxColumn";
            // 
            // saldoPesosDataGridViewTextBoxColumn
            // 
            this.saldoPesosDataGridViewTextBoxColumn.DataPropertyName = "SaldoPesos";
            this.saldoPesosDataGridViewTextBoxColumn.HeaderText = "Saldo en Pesos";
            this.saldoPesosDataGridViewTextBoxColumn.Name = "saldoPesosDataGridViewTextBoxColumn";
            // 
            // saldoDolaresDataGridViewTextBoxColumn
            // 
            this.saldoDolaresDataGridViewTextBoxColumn.DataPropertyName = "SaldoDolares";
            this.saldoDolaresDataGridViewTextBoxColumn.HeaderText = "Saldo en Dolares";
            this.saldoDolaresDataGridViewTextBoxColumn.Name = "saldoDolaresDataGridViewTextBoxColumn";
            // 
            // vistaTarjetaBindingSource
            // 
            this.vistaTarjetaBindingSource.DataSource = typeof(EP1_POO_EmilianoAndrada.Clases.VistaTarjeta);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTarjetaDataGridViewTextBoxColumn1,
            this.fechaOtorgamientoDataGridViewTextBoxColumn1,
            this.fechaVencimientoDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.tarjetaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 356);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(451, 192);
            this.dataGridView3.TabIndex = 2;
            // 
            // nroTarjetaDataGridViewTextBoxColumn1
            // 
            this.nroTarjetaDataGridViewTextBoxColumn1.DataPropertyName = "NroTarjeta";
            this.nroTarjetaDataGridViewTextBoxColumn1.HeaderText = "Numero Tarjeta";
            this.nroTarjetaDataGridViewTextBoxColumn1.Name = "nroTarjetaDataGridViewTextBoxColumn1";
            // 
            // fechaOtorgamientoDataGridViewTextBoxColumn1
            // 
            this.fechaOtorgamientoDataGridViewTextBoxColumn1.DataPropertyName = "FechaOtorgamiento";
            this.fechaOtorgamientoDataGridViewTextBoxColumn1.HeaderText = "Fecha Otorgamiento";
            this.fechaOtorgamientoDataGridViewTextBoxColumn1.Name = "fechaOtorgamientoDataGridViewTextBoxColumn1";
            // 
            // fechaVencimientoDataGridViewTextBoxColumn1
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn1.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn1.HeaderText = "Fecha de Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn1.Name = "fechaVencimientoDataGridViewTextBoxColumn1";
            // 
            // tarjetaBindingSource
            // 
            this.tarjetaBindingSource.DataSource = typeof(EP1_POO_EmilianoAndrada.Clases.Tarjeta);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quitar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Modificar Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1241, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "Modificar Tarjeta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(995, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "Quitar Tarjeta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(685, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Agregar Tarjeta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(505, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 61);
            this.button7.TabIndex = 9;
            this.button7.Text = "Asignar Tarjeta a  cliente";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(685, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 47);
            this.button8.TabIndex = 10;
            this.button8.Text = "Realizar Consumo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(995, 291);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 47);
            this.button9.TabIndex = 11;
            this.button9.Text = "Realizar Pago";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(505, 418);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 61);
            this.button10.TabIndex = 12;
            this.button10.Text = "Quitar Tarjeta a Cliente";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 192);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataSource = typeof(EP1_POO_EmilianoAndrada.Clases.Cliente);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(EP1_POO_EmilianoAndrada.Clases.Cliente);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(EP1_POO_EmilianoAndrada.Clases.Cliente);
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "tipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "tipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "nroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "nroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTarjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaOtorgamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPesosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vistaTarjetaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTarjetaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaOtorgamientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tarjetaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
    }
}

