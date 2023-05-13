using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
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
    public partial class Products : Form
    {
        private readonly IServiceManager _serviceManager;
        private DataTable dt = new DataTable();

        public Products(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            InitializeComponent();
        }

        private async void Products_Load(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        private async void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProducts.Rows[e.RowIndex];
            var value = row.Cells[0].Value.ToString();
            var item = await _serviceManager.ProductService.GetById(Guid.Parse(value!), false)!;
        
            if (item != null)
            {
                lblId.Text = item.Id.ToString();
                lblAverageCost.Text = item.CostPrice.ToString();
                lblStock.Text = item.Stock.ToString();
                txtName.Text = item.Name;
                txtPrice.Text = item.SalePrice.ToString();
            }

            ResetButtons(false, true, true);
        }

        private async Task LoadProducts()
        {
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Precio Venta", typeof(string));
                dt.Columns.Add("Costo Promedio", typeof(string));
                dt.Columns.Add("Existencias", typeof(string));
            }

            var items = await _serviceManager.ProductService.GetAll(new RequestParameters(), false);

            if (dt.Rows.Count > 0)
                dt.Rows.Clear();

            foreach (var item in items)
            {
                DataRow row = dt.NewRow();
                row["ID"] = item.Id!;
                row["Nombre"] = item.Name!;
                row["Precio Venta"] = item.SalePrice;
                row["Costo Promedio"] = item.CostPrice!;
                row["Existencias"] = item.Stock;

                dt.Rows.Add(row);
            }

            dgvProducts.DataSource = dt;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void ResetForm()
        {
            lblId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            lblStock.Text = "0";
            lblAverageCost.Text = "0.0";
        }

        private void ResetButtons(bool add, bool update, bool setnew)
        {
            btnAdd.Enabled = add;
            btnNew.Enabled = update;
            btnUpdate.Enabled = setnew;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var product = GetProductFormDto();

            try
            {
                await _serviceManager.ProductService.CreateProduct(product);

                await LoadProducts();
                ResetForm();
                ResetButtons(true, false, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Se encontraron los siguientes errores: \n{ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = GetProductFormDto();

            try
            {
                await _serviceManager.ProductService.UpdateProduct(product);

                await LoadProducts();
                ResetForm();
                ResetButtons(true, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se encontraron los siguientes errores: \n{ex.Message}");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
            ResetButtons(true, false, false);
        }

        private ProductFormDto GetProductFormDto() => new ProductFormDto
        {
            Description = txtName.Text,
            Name = txtName.Text,
            SalePrice = double.Parse(txtPrice.Text),
            Id = Guid.Parse(lblId.Text)
        };
    }
}
