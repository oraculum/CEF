using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEF
{
    public partial class ClienteUI_Buscar : Form
    {
        public Int32 selectCliente { get; private set; }

        public ClienteUI_Buscar()
        {
            InitializeComponent();
        }

        private void fillGrid()
        {
            List<Cliente> lo = new List<Cliente>();

            if (txtBuscaNome.TextLength > 0)
                lo = ClienteBLL.list(txtBuscaNome.Text);
            else
                lo = ClienteBLL.listAll();

            DataTable dt = Common.converteListDataTable<Cliente>(lo);
            dataGridView1.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void txtBuscaNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillGrid();
        }

        private void selectItem()
        {
            DataGridViewRow dtr = dataGridView1.CurrentRow;
            selectCliente = Int32.Parse(dtr.Cells[0].Value.ToString());

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                selectItem();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectItem();
        }
    }
}
