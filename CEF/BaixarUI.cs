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
    public partial class BaixarUI : Form
    {
        public BaixarUI()
        {
            InitializeComponent();
            txtCliente.Select();
            this.AcceptButton = btnBuscar;
            toolStripStatusLabel1.Text = "";
            txtDataIN.Value = new DateTime(2010, 1, 1);
            txtDataFN.Value = DateTime.Today.Date;
        }

        private Boolean validForm()
        {
            if ((txtCliente.TextLength == 0) && (txtNumDoc.TextLength == 0) && (txtNossoNum.TextLength ==0))
            {
                toolStripStatusLabel1.Text = "Preencha um dos filtros acima antes de buscar.";
                return false;
            }
            else if (txtNumDoc.TextLength > 0)
            {
                txtNossoNum.ResetText();
                txtCliente.ResetText();
                return true;
            }
            else if (txtNossoNum.TextLength > 0)
            {
                txtNumDoc.ResetText();
                txtCliente.ResetText();
                return true;
            }
            else if (txtCliente.TextLength > 0)
            {
                txtNumDoc.ResetText();
                txtNossoNum.ResetText();
                return true;
            }
            else
                return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validForm())
                atuGrid();
        }

        private void atuGrid()
        {
            Int16 situacao = 0;
            if (rbtAberto.Checked)
                situacao = 1;
            else if (rbtPago.Checked)
                situacao = 2;
            else
                situacao = 0;

            DataTable dt = Common.converteListDataTable<Boleto>(BoletoBLL.listBySituacao(txtCliente.Text,
                DateTime.Parse(txtDataIN.Text), DateTime.Parse(txtDataFN.Text), situacao,
                txtNumDoc.Text, txtNossoNum.Text));
            dataGridView1.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        private int status = 0; // usado para nao ficar aparecendo a showbox de confirmacao quando o usuario selecionar varias linhas
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!e.Row.IsNewRow)
            {
                if (status == 0)
                {
                    DialogResult response = MessageBox.Show("ATENÇÃO ESSA OPERAÇÃO NÃO PODERÁ SER DESFEITA.\nVocê tem certeza que deseja deletar as boletas selecionadas?", "Deletar Boletas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (response == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true;
                        status = 2; // coloco status 2 caso o usuario selecione não então quando ele for varrer as outras linhas para excluir ele sabe que o usuario responde nao
                    }
                    else
                    {
                        if (status != 2)
                        {
                            Int32 numdoc = Int32.Parse(e.Row.Cells[4].Value.ToString());
                            BoletoBLL.del(numdoc);
                        }
                    }
                }
                else
                {
                    if (status != 2)
                    {
                        Int32 numdoc = Int32.Parse(e.Row.Cells[4].Value.ToString());
                        BoletoBLL.del(numdoc);
                    }
                }

                int qtselecionada = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (qtselecionada == 1)
                    status = 0;
                else
                {
                    status = 1;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    Int32 id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Boleto o = BoletoBLL.get(id);
                    if (o.Recebido)
                        MessageBox.Show("Essa boleta já está quitada.");
                    else
                    {
                        o.Recebido = true;
                        o.DataRecebido = DateTime.Now.Date;
                        BoletoBLL.save(ref o);

                        atuGrid();
                    }
                }
            }
        }
    }
}
