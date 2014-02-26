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
        private Int32 intQtde;

        public Retorno()
        {
            InitializeComponent();
            lblResult.Text = "";
            toolStripStatusLabel1.Text = "";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
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

                    toolStripStatusLabel1.Text = "Processando linha " + nLoopCtr.ToString();
                    Application.DoEvents();
                    nLoopCtr++;

                    fields = processLine(line);
                    if (fields[0] != null)
                    {
                        intNossoNum += 1;
                        Boleto b = BoletoBLL.get(Int32.Parse(fields[0]));
                        if (b.ID > 0)
                        {
                            b.DataRecebido = DateTime.Parse(fields[1]);
                            b.ValorRecebido = Decimal.Parse(fields[2]);
                            b.Recebido = true;

                            BoletoBLL.save(ref b);

                            lblResult.Text += fields[0] + " - " + b.Cliente.Nome + Environment.NewLine;
                        }
                        else
                        {
                            lblResult.Text += fields[0] + " - *** NOSSO NUMERO NÃO LOCALIZADO NO BANCO DE DADOS ***" + Environment.NewLine;
                            blnBolNaoLoc = true;
                        }
                    }
                }

                if (intQtde != intNossoNum)
                    MessageBox.Show("Atenção: arq. retorno " + intQtde.ToString() +
                        " Nosso Num encontrados " + intNossoNum.ToString());

                if (blnBolNaoLoc)
                    MessageBox.Show("Existem boletas que não foram localizadas no banco de dados");


                toolStripStatusLabel1.Text = "Processo finalizado";
            }
        }

        private String[] processLine(String line)
        {
            String[] fields = new String[3];
            if (line.Length > 19)
            {
                if (line.Substring(0, 3).Equals("024"))
                {
                    if (line.Substring(193, 3).Equals("LIQ"))
                    {
                        fields[0] = line.Substring(3, 15);
                        fields[1] = line.Substring(87, 10).Replace(".", "/");
                        fields[2] = line.Substring(125, 10).Replace(" ", "");
                    }
                }
                else if (line.Substring(0, 10).Equals("QUANTIDADE"))
                    intQtde = Int32.Parse(line.Substring(70, 3));
            }

            return fields;
        }
    }
}
