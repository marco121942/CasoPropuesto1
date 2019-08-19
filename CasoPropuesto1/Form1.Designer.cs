namespace CasoPropuesto1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.DgClientes = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompañiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neptunoDataSet = new CasoPropuesto1.neptunoDataSet();
            this.clientesTableAdapter = new CasoPropuesto1.neptunoDataSetTableAdapters.clientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(283, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Listado de Clientes";
            this.lblTitulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFiltro.Location = new System.Drawing.Point(77, 80);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(154, 16);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "NOMBRE DEL CLIENTE :";
            this.lblFiltro.Click += new System.EventHandler(this.LblFiltro_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(238, 80);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(378, 24);
            this.txtFiltro.TabIndex = 2;
            // 
            // DgClientes
            // 
            this.DgClientes.AllowUserToAddRows = false;
            this.DgClientes.AllowUserToDeleteRows = false;
            this.DgClientes.AutoGenerateColumns = false;
            this.DgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreCompañiaDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.cargoContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn});
            this.DgClientes.DataSource = this.clientesBindingSource;
            this.DgClientes.Location = new System.Drawing.Point(80, 126);
            this.DgClientes.Name = "DgClientes";
            this.DgClientes.ReadOnly = true;
            this.DgClientes.Size = new System.Drawing.Size(652, 183);
            this.DgClientes.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(484, 328);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL DE CLIENTES :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(632, 325);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(623, 80);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(109, 23);
            this.btnFiltro.TabIndex = 6;
            this.btnFiltro.Text = "BUSCAR";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompañiaDataGridViewTextBoxColumn
            // 
            this.nombreCompañiaDataGridViewTextBoxColumn.DataPropertyName = "NombreCompañia";
            this.nombreCompañiaDataGridViewTextBoxColumn.HeaderText = "NombreCompañia";
            this.nombreCompañiaDataGridViewTextBoxColumn.Name = "nombreCompañiaDataGridViewTextBoxColumn";
            this.nombreCompañiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoContactoDataGridViewTextBoxColumn
            // 
            this.cargoContactoDataGridViewTextBoxColumn.DataPropertyName = "CargoContacto";
            this.cargoContactoDataGridViewTextBoxColumn.HeaderText = "CargoContacto";
            this.cargoContactoDataGridViewTextBoxColumn.Name = "cargoContactoDataGridViewTextBoxColumn";
            this.cargoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.neptunoDataSet;
            // 
            // neptunoDataSet
            // 
            this.neptunoDataSet.DataSetName = "neptunoDataSet";
            this.neptunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.DgClientes);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView DgClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFiltro;
        private neptunoDataSet neptunoDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private neptunoDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompañiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
    }
}

