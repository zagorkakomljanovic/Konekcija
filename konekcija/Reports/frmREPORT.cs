using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace konekcija
{
    public partial class frmREPORT : Form
    {        

        public frmREPORT()
        {
            InitializeComponent();
        }

        public frmREPORT(List<konekcija.frmCARDHOLDER.AccessLogReport> listaREP, string param1, string param2) : this()
        {
            ReportDataSource ds = new ReportDataSource();
            ds.Name = "DataSet1";
            ds.Value = listaREP;

            reportViewer1.LocalReport.DataSources.Add(ds);

            reportViewer1.LocalReport.ReportPath = "Report/repCARDHOLDER,rdlc";

            ReportParameter reppar1 = new ReportParameter("cardholder-rep", param1);
            reportViewer1.LocalReport.SetParameters(reppar1);

            ReportParameter reppar2 = new ReportParameter("kontrola", param2);
            reportViewer1.LocalReport.SetParameters(reppar2);

            //public FormREPORT(List<TexEnterijer.FormIZVJESTAJI.KriticnaVrednost> lista, string param1, string param2) : this()
            //{

            //    ReportDataSource ds = new ReportDataSource();
            //    ds.Name = "DataSet1";
            //    ds.Value = lista;

            //    reportViewer1.LocalReport.DataSources.Add(ds);

            //    reportViewer1.LocalReport.ReportPath = "Report/repKRITICNAKOLICINA.rdlc";

            //    ReportParameter nebul = new ReportParameter("kriticnakolicina", param1);
            //    reportViewer1.LocalReport.SetParameters(nebul);

            //    ReportParameter nebul2 = new ReportParameter("texenterijer", param2);
            //    reportViewer1.LocalReport.SetParameters(nebul2);
            //}

        }      
        private void frmREPORT_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void frmREPORT_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
