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
    public partial class ProductsReportViewer : Form
    {
        public ProductsReportViewer()
        {
            InitializeComponent();
        }

        private void ProductsReportViewer_Load(object sender, EventArgs e)
        {
            ProductsViewTableAdapter adapter = new ProductsViewTableAdapter();
            ReportDataSource datasouce = new ReportDataSource("DsProducts", adapter.GetData().Rows);

            rvProducts.LocalReport.ReportEmbeddedResource = "Proyecto.ETPS4.Grupo13.Desktop.Reporting.ProductsReport.rdlc";
            rvProducts.LocalReport.DataSources.Add(datasouce);
            rvProducts.RefreshReport();
        }
    }
}
