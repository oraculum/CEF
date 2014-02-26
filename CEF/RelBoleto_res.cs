using BLL;
using Microsoft.Reporting.WinForms;
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
    public partial class RelBoleto_res : Form
    {
        private DateTime datain, datafn;
        Boolean recebido;
        String tipo;
        List<Entity.Boleto> lb = new List<Entity.Boleto>();
        public RelBoleto_res(DateTime tdatain, DateTime tdatafn, Boolean trecebido)
        {
            InitializeComponent();
            datain = tdatain;
            datafn = tdatafn;
            recebido = trecebido;
            tipo = getTipo();
            lb = BoletoBLL.listBoletos(datain, datafn, recebido);
        }

        private String getTipo()
        {
            if (recebido)
                return "Pagas";
            else
                return "Abertas";
        }

        private void RelBoleto_res_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Boletos", lb));

            ReportParameter[] rp = new ReportParameter[3];
            rp[0] = new ReportParameter("DataIN", datain.ToShortDateString(), false);
            rp[1] = new ReportParameter("DataFN", datafn.ToShortDateString(), false);
            rp[2] = new ReportParameter("Tipo", tipo, false);

            reportViewer1.LocalReport.SetParameters(rp);
            this.reportViewer1.RefreshReport();
        }
    }
}
