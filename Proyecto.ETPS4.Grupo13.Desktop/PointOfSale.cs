using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Enums;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
using System.Data;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class PointOfSale : Form
    {
        private readonly IServiceManager _serviceManager;
        private UserSession _userSession;
        private DataTable dt = new DataTable();
        public PointOfSale(IServiceManager serviceManager, UserSession userSession)
        {
            _serviceManager = serviceManager;
            _userSession = userSession;
            InitializeComponent();
        }

        private async void PointOfSale_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(string));
            dt.Columns.Add("Precio", typeof(string));
            dt.Columns.Add("SubTotal", typeof(string));

            var user = _userSession.User;
            lblUser.Text = user!.UserName;
            lblUserId.Text = user!.Id;

            // Customers
            var customers = await _serviceManager.CustomerService.GetAll(new RequestParameters(), false)!;

            foreach (var customer in customers)
                cbCustomer.Items.Add(new ComboBoxObjectFormat { Text = customer.Name, Value = customer.Id.ToString() });

            // Products
            var products = await _serviceManager.ProductService.GetAll(new RequestParameters(), false)!;

            foreach (var product in products)
                cbProducts.Items.Add(new ComboBoxObjectFormat { Text = product.Name, Value = product.Id.ToString() });

            // SaleReceiptType
            cbSaleReceiptType.Items.Add(new ComboBoxObjectFormat { Text = "Ticket", Value = "0" });
            cbSaleReceiptType.Items.Add(new ComboBoxObjectFormat { Text = "Consumidor Final", Value = "1" });
            cbSaleReceiptType.Items.Add(new ComboBoxObjectFormat { Text = "Credito Fiscal", Value = "2" });

            // SaleType
            cbSaleType.Items.Add(new ComboBoxObjectFormat { Text = "Efectivo", Value = "0" });
            cbSaleType.Items.Add(new ComboBoxObjectFormat { Text = "Credito", Value = "1" });
            cbSaleType.Items.Add(new ComboBoxObjectFormat { Text = "Cheque", Value = "2" });
            cbSaleType.Items.Add(new ComboBoxObjectFormat { Text = "Bitcoin", Value = "3" });

            dgProducts.DataSource = dt;

            ResetForm();
        }

        private void StartNewSale()
        {
            cbProducts.Enabled = false;
            txtQuantity.Enabled = false;
            btnAddProduct.Enabled = false;

            dgProducts.Enabled = false;

            cbCustomer.Enabled = true;
            cbSaleReceiptType.Enabled = true;
            cbSaleType.Enabled = true;

            btnSaveHeader.Enabled = true;
            btnFinish.Enabled = false;
            btnAddNewSale.Enabled = false;
            lblSubTotal.Text = "0.0";
            lblTax.Text = "0.0";
            lblTotal.Text = "0.0";
        }

        private void ResetForm()
        {
            cbProducts.Enabled = false;
            txtQuantity.Enabled = false;
            btnAddProduct.Enabled = false;

            dgProducts.Enabled = false;

            cbCustomer.Enabled = false;
            cbSaleReceiptType.Enabled = false;
            cbSaleType.Enabled = false;

            btnAddNewSale.Enabled = true;
            btnSaveHeader.Enabled = false;
            btnFinish.Enabled = false;
            lblSubTotal.Text = "0.0";
            lblTax.Text = "0.0";
            lblTotal.Text = "0.0";
            cbCustomer.SelectedIndex = 0;
            cbSaleReceiptType.SelectedIndex = 0;
            cbSaleType.SelectedIndex = 0;
            
            txtQuantity.Text = "";
            cbProducts.SelectedIndex = 0;

            if (dt.Rows.Count > 0)
            {
                dt.Rows.Clear();
                dgProducts.Refresh();
            }
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            StartNewSale();
        }

        private async void btnSaveHeader_Click(object sender, EventArgs e)
        {
            cbProducts.Enabled = true;
            txtQuantity.Enabled = true;
            btnAddProduct.Enabled = true;

            dgProducts.Enabled = true;

            cbCustomer.Enabled = false;
            cbSaleReceiptType.Enabled = false;
            cbSaleType.Enabled = false;

            btnAddNewSale.Enabled = false;
            btnSaveHeader.Enabled = false;
            btnFinish.Enabled = true;

            var customerCb = (ComboBoxObjectFormat)cbCustomer.SelectedItem;
            var saleTypecb = (ComboBoxObjectFormat)cbSaleType.SelectedItem;
            var saleReceiptTypeCb = (ComboBoxObjectFormat)cbSaleReceiptType.SelectedItem;

            // SaleHeader object
            var saleHeader = new SaleHeader
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.Parse(customerCb.Value!),
                SaleType = (SaleType)int.Parse(saleTypecb.Value!),
                SaleReceiptType = (SaleReceiptType)int.Parse(saleReceiptTypeCb.Value!),
                UserId = lblUserId.Text
            };

            await _serviceManager.SaleHeaderService.CreateItem(saleHeader);

            lblHeaderId.Text = saleHeader.Id.ToString();
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            await _serviceManager.SaleHeaderService.UpdateItem(Guid.Parse(lblHeaderId.Text), GetSaleHeaderDto(InvoiceStatus.Finished));
            ResetForm();
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            var productCb = (ComboBoxObjectFormat)cbProducts.SelectedItem;
            var productId = Guid.Parse(productCb.Value!);
            var quantity = int.Parse(txtQuantity.Text);
            var product = await _serviceManager.ProductService.GetById(productId, false)!;

            var saleDetail = new SaleDetail
            {
                Id = Guid.NewGuid(),
                SaleHeaderId = Guid.Parse(lblHeaderId.Text),
                ProductId = productId,
                ProductDescription = product.Name,
                Quantity = quantity,
                Price = product.SalePrice,
                SubTotal = quantity * product.SalePrice
            };

            await _serviceManager.SaleDetailService.CreateItem(saleDetail);

            cbProducts.SelectedIndex = 0;
            txtQuantity.Text = "";

            DataRow row = dt.NewRow();
            row["Producto"] = saleDetail.ProductDescription!;
            row["Cantidad"] = saleDetail.Quantity!;
            row["Precio"] = saleDetail.Price!;
            row["SubTotal"] = saleDetail.SubTotal!;

            dt.Rows.Add(row);

            dgProducts.Update();

            var subTotal = Convert.ToDouble(lblSubTotal.Text);
            subTotal += saleDetail.SubTotal!;

            var tax = subTotal * 0.13;
            lblSubTotal.Text = subTotal.ToString();
            lblTax.Text = tax.ToString();
            lblTotal.Text = (subTotal + tax).ToString();

            await _serviceManager.SaleHeaderService.UpdateItem(Guid.Parse(lblHeaderId.Text), GetSaleHeaderDto());
        }

        private SaleHeaderFormDto GetSaleHeaderDto(InvoiceStatus status = InvoiceStatus.InProcess) 
        {
            var customerCb = (ComboBoxObjectFormat)cbCustomer.SelectedItem;
            var saleTypecb = (ComboBoxObjectFormat)cbSaleType.SelectedItem;
            var saleReceiptTypeCb = (ComboBoxObjectFormat)cbSaleReceiptType.SelectedItem;

            var dto = new SaleHeaderFormDto
            {
                Id = Guid.Parse(lblHeaderId.Text),
                CustomerId = Guid.Parse(customerCb.Value!),
                SaleType = (SaleType)int.Parse(saleTypecb.Value!),
                SaleReceiptType = (SaleReceiptType)int.Parse(saleReceiptTypeCb.Value!),
                Status = status,
                Total = double.Parse(lblTotal.Text)
            };

            return dto;
        }
    }
}
