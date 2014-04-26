using BLL;
using Entity;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using BoletoNet;

namespace CEF
{
    public partial class GerarUI : Form
    {
        string _arquivo = string.Empty;
        private BoletoPrintUI _impressaoBoleto = new BoletoPrintUI();
        List<BoletoBancario> lbb = new List<BoletoNet.BoletoBancario>();

        public GerarUI()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            lblVencimentos.Text = "";
        }

        private Boolean validForm()
        {
            if (txtCliente.TextLength == 0)
            {
                toolStripStatusLabel1.Text = "Cliente é obrigatório";
                txtCliente.Select();
                return false;
            }
            else if (txtValor.TextLength == 0)
            {
                toolStripStatusLabel1.Text = "Valor é obrigatório";
                txtValor.Select();
                return false;
            }
            else if (txtQtde.TextLength == 0)
            {
                toolStripStatusLabel1.Text = "Qtde é obrigatório";
                txtQtde.Select();
                return false;
            }
            else if (txtVencimento.TextLength == 0)
            {
                toolStripStatusLabel1.Text = "Vencimento é obrigatório";
                txtVencimento.Select();
                return false;
            }
            else
                return true;
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (validForm())
            {
                List<Entity.Boleto> lb = new List<Entity.Boleto>();

                Int16 qtde = Int16.Parse(txtQtde.Text);
                DateTime venc = DateTime.Parse(txtVencimento.Text);
                lblVencimentos.Text = "";

                for (int i=0; i<qtde; i++)
                {
                    Entity.Boleto o = new Entity.Boleto();
                    o.Cliente = ClienteBLL.get(Int32.Parse(txtCliente.Text));
                    o.Valor = Decimal.Parse(txtValor.Text);
                    o.Obs1 = txtObs1.Text;
                    o.Obs2 = txtObs2.Text;
                    o.Obs3 = txtObs3.Text;
                    o.Vencimento = venc;

                    BoletoBLL.save(ref o);
                    lb.Add(o);

                    lblVencimentos.Text += venc.ToShortDateString() + Environment.NewLine;
                    venc = venc.AddMonths(1);
                }

                lbb = new List<BoletoNet.BoletoBancario>();

                foreach(Entity.Boleto boleto in lb)
                {
                    Configuracao config = ConfiguracaoBLL.get();
                    Entity.Boleto b = boleto;
                    BoletoBancario bb = new BoletoBancario();
                    bb.CodigoBanco = 104;
                    bb.OcultarInstrucoes = true;
                    
                    Cedente c = new Cedente(config.CNPJ, config.RazaoSocial, config.Agencia, config.Conta_Format, config.ContaDigito);
                    c.Codigo = config.Cedente;
                    String base_nossnum = (24000000000000000 + b.ID).ToString();
                    BoletoNet.Boleto bol = new BoletoNet.Boleto(b.Vencimento, b.Valor, "SR", base_nossnum, c);
                    bol.NumeroDocumento = b.ID.ToString();
                    bol.Sacado = new Sacado(b.Cliente.CNPJ, b.Cliente.Nome);
                    bol.Sacado.Endereco.End = b.Cliente.Endereco;
                    bol.Sacado.Endereco.Numero = b.Cliente.Numero;
                    bol.Sacado.Endereco.Bairro = b.Cliente.Bairro;
                    bol.Sacado.Endereco.Cidade = b.Cliente.Cidade;
                    bol.Sacado.Endereco.UF = b.Cliente.UF;
                    bol.Sacado.Endereco.CEP = b.Cliente.CEP;

                    bol.DataDocumento = DateTime.Today.Date;
                    bol.ValorBoleto = b.Valor;
                    Instrucao lot = new Instrucao(104);
                    lot.Descricao = config.Descricao;
                    bol.Instrucoes.Add(lot);
                    
                    if (b.Obs1.Length > 0)
                    {
                        Instrucao obs1 = new Instrucao(104);
                        obs1.Descricao = b.Obs1;
                        bol.Instrucoes.Add(obs1);
                    }
                    if (b.Obs2.Length > 0)
                    {
                        Instrucao obs2 = new Instrucao(104);
                        obs2.Descricao = b.Obs2;
                        bol.Instrucoes.Add(obs2);
                    }
                    if (b.Obs3.Length > 0)
                    {
                        Instrucao obs3 = new Instrucao(104);
                        obs3.Descricao = b.Obs3;
                        bol.Instrucoes.Add(obs3);
                    }

                    bb.Boleto = bol;
                    bb.Boleto.Valida();

                    //salvando o nosso numero depois de gerado
                    b.NossoNum = bb.Boleto.NossoNumero;
                    BoletoBLL.save(ref b);
                    
                    lbb.Add(bb);
                }

                GeraLayout();
                _impressaoBoleto.webBrowser1.Navigate(_arquivo);
                _impressaoBoleto.ShowDialog();


                toolStripStatusLabel1.Text = "Boletos gerados";
            }
        }

        private void GeraLayout()
        {
            StringBuilder html = new StringBuilder();
            int total = lbb.Count;
            int current = 0;
            foreach(BoletoNet.BoletoBancario o in lbb)
            {
                current += 1;
                if (total == current)
                    html.Append(@"<div>");
                else
                    html.Append(@"<div style='page-break-after:always'>");
                html.Append(o.MontaHtml());
                html.Append("</div>");
            }

            _arquivo = System.IO.Path.GetTempFileName();

            using(FileStream f = new FileStream(_arquivo, FileMode.Create))
            {
                StreamWriter w = new StreamWriter(f, System.Text.Encoding.Default);
                w.Write(html.ToString());
                w.Close();
                f.Close();
            }
        }


        private void clearForm()
        {
            txtCliente.ResetText();
            txtValor.ResetText();
            txtObs1.ResetText();
            txtObs2.ResetText();
            txtObs3.ResetText();

            txtCliente.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearForm();
            txtQtde.ResetText();
            txtVencimento.ResetText();
        }

    }
}
