using Microsoft.Reporting.WinForms;
using Proyecto.ETPS4.Grupo13.Desktop.DsGlobalTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class SalesReportViewer : Form
    {
        public SalesReportViewer()
        {
            InitializeComponent();
        }

        private void SalesReportViewer_Load(object sender, EventArgs e)
        {
            SalesViewTableAdapter adapter = new SalesViewTableAdapter();
            ReportDataSource datasource = new ReportDataSource("DsSales", adapter.GetData().Rows);
            rvSales.LocalReport.ReportEmbeddedResource = "Proyecto.ETPS4.Grupo13.Desktop.Reporting.SalesReport.rdlc";
            rvSales.LocalReport.DataSources.Add(datasource);
            rvSales.RefreshReport();
        }
    }
}
