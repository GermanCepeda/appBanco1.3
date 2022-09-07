namespace appBanco1._3
{
    partial class FrmPrincipal
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
            this.btnCargarcliente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.CBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.gpbCuentas = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblidCliente = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.altaBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.gpbCuentas.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarcliente
            // 
            this.btnCargarcliente.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarcliente.Location = new System.Drawing.Point(7, 317);
            this.btnCargarcliente.Name = "btnCargarcliente";
            this.btnCargarcliente.Size = new System.Drawing.Size(338, 47);
            this.btnCargarcliente.TabIndex = 2;
            this.btnCargarcliente.Text = "Cargar Cuenta";
            this.btnCargarcliente.UseVisualStyleBackColor = true;
            this.btnCargarcliente.Click += new System.EventHandler(this.btnCargarcliente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaBajaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.archivoToolStripMenuItem.Text = "Opciones";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvClientes.Location = new System.Drawing.Point(7, 80);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(343, 228);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(12, 41);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(338, 36);
            this.lblListaClientes.TabIndex = 5;
            this.lblListaClientes.Text = "Lista de Clientes";
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBU,
            this.SALDO,
            this.TipoDeCuenta,
            this.UltimoMovimiento});
            this.dgvCuentas.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCuentas.Location = new System.Drawing.Point(585, 80);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(467, 228);
            this.dgvCuentas.TabIndex = 6;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // CBU
            // 
            this.CBU.DataPropertyName = "CBU";
            this.CBU.HeaderText = "CBU";
            this.CBU.Name = "CBU";
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            // 
            // TipoDeCuenta
            // 
            this.TipoDeCuenta.DataPropertyName = "Tipo De Cuenta";
            this.TipoDeCuenta.HeaderText = "Tipo De Cuenta";
            this.TipoDeCuenta.Name = "TipoDeCuenta";
            // 
            // UltimoMovimiento
            // 
            this.UltimoMovimiento.DataPropertyName = "Ultimo Movimiento";
            this.UltimoMovimiento.HeaderText = "Ultimo Movimiento";
            this.UltimoMovimiento.Name = "UltimoMovimiento";
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.Location = new System.Drawing.Point(755, 41);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(148, 36);
            this.lblCuentas.TabIndex = 7;
            this.lblCuentas.Text = "Cuentas";
            // 
            // gpbCuentas
            // 
            this.gpbCuentas.Controls.Add(this.lblSaldo);
            this.gpbCuentas.Controls.Add(this.lblTipoCuenta);
            this.gpbCuentas.Controls.Add(this.lblidCliente);
            this.gpbCuentas.Controls.Add(this.txtSaldo);
            this.gpbCuentas.Controls.Add(this.txtidCliente);
            this.gpbCuentas.Controls.Add(this.cboTipoCuenta);
            this.gpbCuentas.Controls.Add(this.btnAgregarCuenta);
            this.gpbCuentas.Location = new System.Drawing.Point(627, 373);
            this.gpbCuentas.Name = "gpbCuentas";
            this.gpbCuentas.Size = new System.Drawing.Size(383, 185);
            this.gpbCuentas.TabIndex = 8;
            this.gpbCuentas.TabStop = false;
            this.gpbCuentas.Text = "Cuentas";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(60, 94);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(58, 18);
            this.lblSaldo.TabIndex = 26;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.Location = new System.Drawing.Point(6, 57);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(148, 18);
            this.lblTipoCuenta.TabIndex = 25;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // lblidCliente
            // 
            this.lblidCliente.AutoSize = true;
            this.lblidCliente.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCliente.Location = new System.Drawing.Point(6, 19);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(148, 18);
            this.lblidCliente.TabIndex = 24;
            this.lblidCliente.Text = "ID del cliente";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(173, 94);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(191, 20);
            this.txtSaldo.TabIndex = 23;
            // 
            // txtidCliente
            // 
            this.txtidCliente.Enabled = false;
            this.txtidCliente.Location = new System.Drawing.Point(173, 19);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(191, 20);
            this.txtidCliente.TabIndex = 22;
            this.txtidCliente.TextChanged += new System.EventHandler(this.txtidCliente_TextChanged);
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(173, 57);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(191, 21);
            this.cboTipoCuenta.TabIndex = 21;
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuenta.Location = new System.Drawing.Point(63, 120);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(282, 42);
            this.btnAgregarCuenta.TabIndex = 20;
            this.btnAgregarCuenta.Text = "Agregar Cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.button1);
            this.gpbCliente.Controls.Add(this.txtDni);
            this.gpbCliente.Controls.Add(this.txtApellido);
            this.gpbCliente.Controls.Add(this.txtNombre);
            this.gpbCliente.Controls.Add(this.lblDni);
            this.gpbCliente.Controls.Add(this.lblApellido);
            this.gpbCliente.Controls.Add(this.lblNombre);
            this.gpbCliente.Location = new System.Drawing.Point(0, 373);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(350, 185);
            this.gpbCliente.TabIndex = 9;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(133, 94);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(191, 20);
            this.txtDni.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(133, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(68, 94);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 18);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "Dni";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(27, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 18);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // altaBajaToolStripMenuItem
            // 
            this.altaBajaToolStripMenuItem.Name = "altaBajaToolStripMenuItem";
            this.altaBajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaBajaToolStripMenuItem.Text = "Alta/Baja";
            this.altaBajaToolStripMenuItem.Click += new System.EventHandler(this.altaBajaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 592);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.gpbCuentas);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCargarcliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblListaClientes);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "º";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.gpbCuentas.ResumeLayout(false);
            this.gpbCuentas.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargarcliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoMovimiento;
        private System.Windows.Forms.GroupBox gpbCuentas;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblidCliente;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem altaBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

