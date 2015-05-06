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
    public partial class Envelope : Form
    {
        public Envelope()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Envelope_res o = new Envelope_res((String.IsNullOrEmpty(txtCliente.Text) ? 0 : Int32.Parse(txtCliente.Text)));
            o.Show();
        }
    }
}
