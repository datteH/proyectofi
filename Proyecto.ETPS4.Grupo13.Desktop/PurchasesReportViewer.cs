using Microsoft.Reporting.WinForms;
using Proyecto.ETPS4.Grupo13.Desktop.DsGlobalTableAdapters;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class PurchasesReportViewer : Form
    {
        public PurchasesReportViewer()
        {
            InitializeComponent();
        }

        private void PurchasesReportViewer_Load(object sender, EventArgs e)
        {
            PurchasesViewTableAdapter purchases = new PurchasesViewTableAdapter();
            ReportDataSource datasource = new ReportDataSource("DsPurchases", purchases.GetData().Rows);

            rvPurchases.LocalReport.ReportEmbeddedResource = "Proyecto.ETPS4.Grupo13.Desktop.Reporting.PurchasesReport.rdlc";
            rvPurchases.LocalReport.DataSources.Add(datasource);
            rvPurchases.RefreshReport();
        }
    }
}
