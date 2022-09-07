using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace appBanco1._3
{
    public partial class FrmPrincipal : Form
    {
        DBHelper oDB = new DBHelper();
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCliente(dgvClientes);
            CargarTipos();
        }

       

        private void cargarCliente(DataGridView dgv)
        {
            DataTable table = oDB.ConsultaSQL("spCargarCliente");
            dgv.DataSource = table;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private int BuscarID()
        {
            DataTable table = oDB.BuscarID("spBuscarID", dgvClientes.CurrentRow.Cells[2].Value.ToString());
            int id;
            id = Convert.ToInt32(table.Rows[0]["id_cliente"]);
            return id;
        }

        private void  CargarCuenta(DataGridView dgv)
        {
            DataTable table = oDB.BuscarCuenta("spCargarCuenta", BuscarID());
            dgv.DataSource=table;
        }

        private void btnCargarcliente_Click(object sender, EventArgs e)
        {
            CargarCuenta(dgvCuentas);
        }

       

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            oDB.InsertarCuenta(Convert.ToInt32(txtidCliente.Text), Convert.ToInt32(txtSaldo.Text), cboTipoCuenta.SelectedIndex);
            MessageBox.Show("La cuenta se agrego correctamente");
            cargarCliente(dgvClientes);
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oDB.InsertarCliente(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text),
                cboTipoCuenta.SelectedIndex);
            MessageBox.Show("El cliente se inserto correctamente");
            cargarCliente(dgvClientes);
            Limpiar();
        }


        private void CargarTipos()
        {
            DataTable table = new DataTable();
            table = oDB.ConsultaSQL("spCargarTipo");
            cboTipoCuenta.DataSource = table;
            cboTipoCuenta.ValueMember = table.Columns[0].ColumnName;
            cboTipoCuenta.DisplayMember = table.Columns[1].ColumnName;

        }

        private void txtidCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtidCliente.Text = "";
            cboTipoCuenta.SelectedIndex = 0;
            txtSaldo.Text = "";
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea abandonar la aplicación", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void altaBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAltaBaja().ShowDialog();
            
        }
    }
}
