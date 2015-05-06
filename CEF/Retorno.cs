using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEF
{

    public partial class Retorno : Form
    {
        public class BolProcessada
        {
            public String Cliente { get; set; }
            public String NossoNum { get; set; }
            public Decimal Valor { get; set; }
            public Decimal ValorPago { get; set; }

            public BolProcessada()
            {
                Cliente = String.Empty;
                NossoNum = String.Empty;
                Valor = 0;
                ValorPago = 0;
            }
        }

        private Int32 intQtde;
        List<BolProcessada> listBol;

        public Retorno()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            listBol = new List<BolProcessada>();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            intQtde = 0;

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFileRetorno.Text = openFile.FileName;
                int nLoopCtr = 1;
                int intNossoNum = 0;
                Boolean blnBolNaoLoc = false;
                StreamReader sr = new StreamReader(txtFileRetorno.Text);

                String[] fields = new String[3];

                while(true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;

                    toolStripStatusLabel1.Text = "Processando linhas " + nLoopCtr.ToString();
                    Application.DoEvents();
                    nLoopCtr++;

                    fields = processLine(line);
                    if (fields[0] != null)
                    {
                        BolProcessada bp = new BolProcessada();
                        bp.NossoNum = fields[0];

                        intNossoNum += 1;
                        Boleto b = BoletoBLL.get(Int32.Parse(fields[0]));
                        if (b.ID > 0)
                        {
                            b.DataRecebido = DateTime.Parse(fields[1]);
                            b.ValorRecebido = Decimal.Parse(fields[2]);
                            b.Recebido = true;

                            BoletoBLL.save(ref b);

                            bp.Cliente = b.Cliente.Nome;
                            bp.Valor = b.Valor;
                            bp.ValorPago = b.ValorRecebido;
                        }
                        else
                        {
                            bp.Cliente = "*** NOSSO NUMERO NÃO LOCALIZADO NO BANCO DE DADOS ***";
                            blnBolNaoLoc = true;
                        }

                        listBol.Add(bp);
                        toolStripStatusLabel1.Text = "Processando Nosso Num.: " + fields[0];
                    }
                }

                if (intQtde != intNossoNum)
                    MessageBox.Show("Atenção: arq. retorno " + intQtde.ToString() +
                        "/nNosso Num encontrados " + intNossoNum.ToString());

                if (blnBolNaoLoc)
                    MessageBox.Show("Existem boletas que não foram localizadas no banco de dados");

                dataGridView1.DataSource = listBol;

                toolStripStatusLabel1.Text = "Processo finalizado. Total boletas " + intQtde;
            }
        }

        private String[] processLine(String line)
        {
            String[] fields = new String[3];
            if (line.Length > 19)
            {
                if (line.Substring(0, 2).Equals("24"))
                {
                    if (line.Substring(193, 3).Equals("LIQ"))
                    {
                        fields[0] = line.Substring(3, 15); // nosso numero
                        fields[1] = line.Substring(87, 10).Replace(".", "/"); // data pagamento
                        fields[2] = line.Substring(183, 10).Replace(" ", ""); // valor recebido
                    }
                }
                else if (line.Substring(0, 10).Equals("QUANTIDADE"))
                    intQtde = Int32.Parse(line.Substring(70, 3));
            }

            return fields;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Decimal valor = Decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                Decimal valorPago = Decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                if (((valorPago + 3) < valor) || (valor == 0))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
