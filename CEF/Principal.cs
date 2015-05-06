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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            statusVersion.Text = "Versão: " + Program.AssemblyVersion;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteUI o = new ClienteUI();
            o.Show();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Configuracao o = ConfiguracaoBLL.get();
            if (o.Agencia != null)
            {
                GerarUI g = new GerarUI();
                g.Show();
            }
            else
            {
                MessageBox.Show("É preciso fazer as configurações inicias antes de prosseguir, clique em OK que abriremos a tela de configuração pra você!");
                ConfiguracaoUI c = new ConfiguracaoUI();
                c.ShowDialog();
            }
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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfiguracaoUI c = new ConfiguracaoUI();
            c.ShowDialog();
        }

        private void btnEnvelope_Click(object sender, EventArgs e)
        {
            Envelope el = new Envelope();
            el.Show();
        }

    }
}
