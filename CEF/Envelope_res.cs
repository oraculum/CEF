using BLL;
using Entity;
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
    public partial class Envelope_res : Form
    {
        List<Cliente> lc = new List<Cliente>();

        public Envelope_res(Int32 cliente)
        {
            InitializeComponent();

            if (cliente > 0)
                lc.Add(ClienteBLL.get(cliente));
            else
                lc = ClienteBLL.listAll__Contrato_Ativo();
        }

        private void Envelope_res_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Cliente", lc));

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
            reportViewer1.SetPageSettings(ps);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
