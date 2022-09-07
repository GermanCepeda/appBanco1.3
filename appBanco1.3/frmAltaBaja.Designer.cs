namespace appBanco1._3
{
    partial class frmAltaBaja
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
            this.dgvAlta = new System.Windows.Forms.DataGridView();
            this.dgvBaja = new System.Windows.Forms.DataGridView();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.lblListaAlta = new System.Windows.Forms.Label();
            this.lblListaBaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlta
            // 
            this.dgvAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlta.Location = new System.Drawing.Point(59, 53);
            this.dgvAlta.Name = "dgvAlta";
            this.dgvAlta.Size = new System.Drawing.Size(200, 288);
            this.dgvAlta.TabIndex = 0;
            this.dgvAlta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlta_CellContentClick);
            // 
            // dgvBaja
            // 
            this.dgvBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaja.Location = new System.Drawing.Point(414, 53);
            this.dgvBaja.Name = "dgvBaja";
            this.dgvBaja.Size = new System.Drawing.Size(200, 288);
            this.dgvBaja.TabIndex = 1;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(414, 347);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(200, 42);
            this.btnDarBaja.TabIndex = 2;
            this.btnDarBaja.Text = "Dar de Alta";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.Location = new System.Drawing.Point(59, 347);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(200, 42);
            this.btnDarAlta.TabIndex = 3;
            this.btnDarAlta.Text = "Dar de Baja";
            this.btnDarAlta.UseVisualStyleBackColor = true;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // lblListaAlta
            // 
            this.lblListaAlta.AutoSize = true;
            this.lblListaAlta.Location = new System.Drawing.Point(118, 27);
            this.lblListaAlta.Name = "lblListaAlta";
            this.lblListaAlta.Size = new System.Drawing.Size(82, 13);
            this.lblListaAlta.TabIndex = 4;
            this.lblListaAlta.Text = "Clientes Activos";
            // 
            // lblListaBaja
            // 
            this.lblListaBaja.AutoSize = true;
            this.lblListaBaja.Location = new System.Drawing.Point(475, 27);
            this.lblListaBaja.Name = "lblListaBaja";
            this.lblListaBaja.Size = new System.Drawing.Size(85, 13);
            this.lblListaBaja.TabIndex = 5;
            this.lblListaBaja.Text = "Clientes De Baja";
            // 
            // frmAltaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.lblListaBaja);
            this.Controls.Add(this.lblListaAlta);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.dgvBaja);
            this.Controls.Add(this.dgvAlta);
            this.Name = "frmAltaBaja";
            this.Text = "AltaBaja";
            this.Load += new System.EventHandler(this.AltaBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlta;
        private System.Windows.Forms.DataGridView dgvBaja;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Label lblListaAlta;
        private System.Windows.Forms.Label lblListaBaja;
    }
}