using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class Main : Form
    {
        private readonly IServiceManager _serviceManager;
        private UserSession _userSession;

        public Main(IServiceManager serviceManager, UserSession userSession)
        {
            _serviceManager = serviceManager;
            _userSession = userSession;
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(Users)))
            {
                var users = new Users(_serviceManager);
                users.MdiParent = this;
                users.Show();
            }
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(PointOfSale)))
            {
                var pos = new PointOfSale(_serviceManager, _userSession);
                pos.MdiParent = this;
                pos.Show();
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(Purchases)))
            {
                var purchase = new Purchases(_serviceManager);
                purchase.MdiParent = this;
                purchase.Show();
            }
        }

        private bool FormIsOpened(string form)
        {
            var instances = Application.OpenForms.ToDynamicList().Select(c => c.Name);
            var isOpen = instances.Contains(form);

            if (isOpen)
                Application.OpenForms[form].Focus();

            return isOpen;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(Products)))
            {
                var products = new Products(_serviceManager);
                products.MdiParent = this;
                products.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(Suppliers)))
            {
                var suppliers = new Suppliers(_serviceManager);
                suppliers.MdiParent = this;
                suppliers.Show();
            }
        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(PurchasesReportViewer)))
            {
                var report = new PurchasesReportViewer();
                report.MdiParent = this;
                report.Show();
            }
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(SalesReportViewer)))
            {
                var report = new SalesReportViewer();
                report.MdiParent = this;
                report.Show();
            }
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened(nameof(ProductsReportViewer)))
            {
                var report = new ProductsReportViewer();
                report.MdiParent = this;
                report.Show();
            }
        }
    }
}
