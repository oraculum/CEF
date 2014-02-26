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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteUI o = new ClienteUI();
            o.Show();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarUI g = new GerarUI();
            g.Show();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            BaixarUI b = new BaixarUI();
            b.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelBoleto r = new RelBoleto();
            r.Show();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            Retorno rt = new Retorno();
            rt.Show();
        }

    }
}
