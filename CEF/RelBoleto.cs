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
    public partial class RelBoleto : Form
    {
        public RelBoleto()
        {
            InitializeComponent();
        }

        private Boolean validForm()
        {
            if (!txtDataIN.MaskCompleted)
            {
                MessageBox.Show("Data inicial incorreta.");
                txtDataIN.Focus();
                return false;
            }
            else if (!txtDataFN.MaskCompleted)
            {
                MessageBox.Show("Data final incorreta.");
                txtDataFN.Focus();
                return false;
            }
            else
                return true;
        }

        private Boolean getRadios()
        {
            if (rbtAbertas.Checked)
                return false;
            else
                return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(validForm())
            {
                RelBoleto_res rbr = new RelBoleto_res(DateTime.Parse(txtDataIN.Text),
                    DateTime.Parse(txtDataFN.Text), getRadios());
                rbr.Show();
            }
        }

        private void changeRadio()
        {
            if (rbtAbertas.Checked)
                rbtPagas.Checked = false;
            else
                rbtAbertas.Checked = false;
        }

        private void rbtAbertas_CheckedChanged(object sender, EventArgs e)
        {
            changeRadio();
        }

        private void rbtPagas_CheckedChanged(object sender, EventArgs e)
        {
            changeRadio();
        }
    }
}
