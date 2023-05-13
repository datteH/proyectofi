using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
using System.Data;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class Suppliers : Form
    {
        private DataTable dt = new DataTable();
        private readonly IServiceManager _serviceManager;

        public Suppliers(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;

            InitializeComponent();
        }

        private async void Suppliers_Load(object sender, EventArgs e)
        {
            await LoadSuppliers();
        }

        private async void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvSuppliers.Rows[e.RowIndex];
            var value = row.Cells[0].Value.ToString();
            var item = await _serviceManager.SupplierService.GetById(Guid.Parse(value!), false)!;

            if (item != null)
            {
                lblId.Text = item.Id.ToString();
                txtName.Text = item.Name;
                txtAddress.Text = item.Address;
                txtEmail.Text = item.Email;
                txtPhone.Text = item.Phone;
            }

            ResetButtons(false, true, true);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var supplier = GetSupplier();

            try
            {
                await _serviceManager.SupplierService.CreateItem(supplier);

                await LoadSuppliers();
                ResetForm();
                ResetButtons(true, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se encontraron los siguientes errores: \n{ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var supplier = GetSupplier();

            try
            {
                await _serviceManager.SupplierService.UpdateItem(supplier);

                await LoadSuppliers();
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

        private void ResetButtons(bool add, bool update, bool setnew)
        {
            btnAdd.Enabled = add;
            btnNew.Enabled = update;
            btnUpdate.Enabled = setnew;
        }

        private SupplierFormDto GetSupplier() => new SupplierFormDto
        {
            Name = txtName.Text,
            Address = txtAddress.Text,
            Email = txtEmail.Text,
            Phone = txtPhone.Text,
            Id = Guid.Parse(lblId.Text)
        };

        private async Task LoadSuppliers()
        {
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Correo Electronico", typeof(string));
            }

            var items = await _serviceManager.SupplierService.GetAll(new RequestParameters(), false)!;

            if (dt.Rows.Count > 0)
                dt.Rows.Clear();

            foreach (var item in items)
            {
                DataRow row = dt.NewRow();
                row["ID"] = item.Id!;
                row["Nombre"] = item.Name!;
                row["Correo Electronico"] = item.Email;

                dt.Rows.Add(row);
            }

            dgvSuppliers.DataSource = dt;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void ResetForm()
        {
            lblId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "0";
            txtEmail.Text = "0.0";
        }
    }
}
