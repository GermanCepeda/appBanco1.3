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
    public partial class frmAltaBaja : Form
    {
        DBHelper oDB = new DBHelper();
        public frmAltaBaja()
        {
            InitializeComponent();
        }

        private void AltaBaja_Load(object sender, EventArgs e)
        {
            CargarCliente(dgvAlta);
            CargarBajas(dgvBaja);
        }

        private void CargarCliente(DataGridView dgv)
        {
            DataTable table = oDB.ConsultaSQL("spCargarCliente");
            dgv.DataSource = table;
        }

        private void CargarBajas(DataGridView dgv)
        {
            DataTable table = oDB.ConsultaSQL("spCargarBajas");
            dgv.DataSource = table;
        }




        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            oDB.DarBaja(Convert.ToInt32(dgvAlta.CurrentCell.Value.ToString()));
            MessageBox.Show("El cliente se dio de baja correctamente");
            CargarBajas(dgvBaja);
            CargarCliente(dgvAlta);
        }

        private void dgvAlta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            oDB.DarAlta(Convert.ToInt32(dgvBaja.CurrentCell.Value.ToString()));
            MessageBox.Show("El cliente se dio de alta correctamente");
            CargarBajas(dgvBaja);
            CargarCliente(dgvAlta);
        }
    }
}
