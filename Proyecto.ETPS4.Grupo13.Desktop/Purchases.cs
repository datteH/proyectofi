using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
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
    public partial class Purchases : Form
    {
        private readonly IServiceManager _serviceManager;
        public Purchases(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            InitializeComponent();
        }

        private async void Purchases_Load(object sender, EventArgs e)
        {
            await LoadSuppliers();
            await LoadProducts();
        }

        private void ResetForm()
        {
            txtCost.Text = "";
            txtQuantity.Text = "";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = (ComboBoxObjectFormat)cbSuppliers.SelectedItem;
            var product = (ComboBoxObjectFormat)cbProducts.SelectedItem;
            var purchase = new Purchase
            {
                Id = Guid.NewGuid(),
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Cost = Convert.ToDouble(txtCost.Text),
                SupplierId = Guid.Parse(supplier.Value!),
                ProductId = Guid.Parse(product.Value!),
                PurchasedAt = DateTime.Now,
            };

            await _serviceManager.PurchaseService.CreateItem(purchase);
            MessageBox.Show("Compra guardada con éxito");

            ResetForm();
        }

        private async void btnReloadProvider_Click(object sender, EventArgs e)
        {
            await LoadSuppliers();
        }

        private async void btnReloadProducts_Click(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        private async Task LoadSuppliers()
        {
            // Customers
            var suppliers = await _serviceManager.SupplierService.GetAll(new RequestParameters(), false)!;

            if (cbSuppliers.Items.Count > 0)
                cbSuppliers.Items.Clear();

            foreach (var supplier in suppliers)
                cbSuppliers.Items.Add(new ComboBoxObjectFormat { Text = supplier.Name, Value = supplier.Id.ToString() });
        }

        private async Task LoadProducts()
        {
            // Products
            var products = await _serviceManager.ProductService.GetAll(new RequestParameters(), false)!;

            if (cbProducts.Items.Count > 0)
                cbProducts.Items.Clear();

            foreach (var product in products)
                cbProducts.Items.Add(new ComboBoxObjectFormat { Text = product.Name, Value = product.Id.ToString() });
        }
    }
}
