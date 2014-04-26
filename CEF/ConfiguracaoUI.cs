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
    public partial class ConfiguracaoUI : Form
    {
        public ConfiguracaoUI()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            Configuracao o = ConfiguracaoBLL.get();
            if (o.Agencia != null)
            {
                txtAgencia.Text = o.Agencia;
                txtConta.Text = o.Conta;
                txtContaDigito.Text = o.ContaDigito;
                txtCedente.Text = o.Cedente;
                txtCNPJ.Text = o.CNPJ;
                txtRazao.Text = o.RazaoSocial;
                txtDescricao.Text = o.Descricao;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean validForm()
        {
            if (!txtCNPJ.MaskCompleted)
            {
                toolStripStatusLabel1.Text = "CNPJ é obrigatório";
                txtCNPJ.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtRazao.Text))
            {
                toolStripStatusLabel1.Text = "Razão social é obrigatório";
                txtRazao.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtAgencia.Text))
            {
                toolStripStatusLabel1.Text = "Agência é obrigatório.";
                txtAgencia.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtConta.Text))
            {
                toolStripStatusLabel1.Text = "Conta é obrigatório.";
                txtConta.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtCedente.Text))
            {
                toolStripStatusLabel1.Text = "Cedente é obrigatório";
                txtCedente.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validForm())
            {
                Configuracao o = new Configuracao();
                o.Agencia = txtAgencia.Text;
                o.Conta = txtConta.Text;
                o.ContaDigito = txtContaDigito.Text;
                o.Cedente = txtCedente.Text;
                o.CNPJ = txtCNPJ.Text;
                o.RazaoSocial = txtRazao.Text;
                o.Descricao = txtDescricao.Text;

                ConfiguracaoBLL.save(o);

                toolStripStatusLabel1.Text = "Salvo com sucesso.";
            }
        }
    }
}
