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
    public partial class ClienteUI : Form
    {
        public ClienteUI()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        private Boolean validateForm()
        {
            if (txtCodigo.Text.Equals("0"))
            {
                toolStripStatusLabel1.Text = "Código não pode ser 0.";
                return false;
            }
            else if ((txtCodigo.Text.Length <= 0) || (txtNome.Text.Length <= 0))
            {
                toolStripStatusLabel1.Text = "Código e nome são obrigatórios";
                return false;
            }
            else if (txtFantasia.TextLength <= 0)
            {
                toolStripStatusLabel1.Text = "Nome fantasia é obrigatório.";
                txtFantasia.Select();
                return false;
            }
            else
                return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Cliente o = new Cliente();
                o.Codigo = Int32.Parse(txtCodigo.Text);
                o.Nome = txtNome.Text;
                o.Fantasia = txtFantasia.Text;
                o.CNPJ = txtCNPJ.Text;
                o.IE = txtIE.Text;
                o.Endereco = txtEndereco.Text;
                o.Numero = txtNumero.Text;
                o.Complemento = txtComplemento.Text;
                o.Bairro = txtBairro.Text;
                o.Cidade = txtCidade.Text;
                o.UF = txtUF.Text;
                o.CEP = txtCEP.Text;

                ClienteBLL.save(o);
                toolStripStatusLabel1.Text = "Salvo com sucesso";
            }
        }

        private void clearForm()
        {
            toolStripStatusLabel1.Text = "";

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)C;
                    txt.ResetText();
                }
                else if (C.GetType() == typeof(MaskedTextBox))
                {
                    MaskedTextBox txt = (MaskedTextBox)C;
                    txt.ResetText();
                }
            }

            txtCidade.Text = "Volta Redonda";
            txtUF.Text = "RJ";

            txtCodigo.Enabled = true;
            txtCodigo.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void fillForm(Cliente o)
        {
            if (o.Codigo > 0)
            {
                txtCodigo.Text = o.Codigo.ToString();
                txtNome.Text = o.Nome;
                txtFantasia.Text = o.Fantasia;
                txtCNPJ.Text = o.CNPJ;
                txtIE.Text = o.IE;
                txtEndereco.Text = o.Endereco;
                txtNumero.Text = o.Numero;
                txtComplemento.Text = o.Complemento;
                txtBairro.Text = o.Bairro;
                txtCidade.Text = o.Cidade;
                txtUF.Text = o.UF;
                txtCEP.Text = o.CEP;
                txtCodigo.Enabled = false;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
                fillForm(ClienteBLL.get(Int32.Parse(txtCodigo.Text)));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = ClienteBLL.nextCodigo().ToString();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza?", "Apagar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                ClienteBLL.del(Int32.Parse(txtCodigo.Text));
                clearForm();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(ClienteUI_Buscar cb = new ClienteUI_Buscar())
            {
                if (cb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fillForm(ClienteBLL.get(cb.selectCliente));
                }
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtFantasia.TextLength == 0)
            {
                txtFantasia.Text = txtNome.Text;
                txtFantasia.SelectAll();
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            txtCidade.Focus();
            txtCidade.SelectAll();
        }
    }
}
