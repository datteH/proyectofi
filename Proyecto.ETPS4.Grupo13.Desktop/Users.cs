using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Enums;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
using System.Data;
using System.Linq;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class Users : Form
    {
        private DataTable dt = new DataTable();
        private readonly IServiceManager _serviceManager;
        public Users(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;

            InitializeComponent();
        }

        private async void Users_Load(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgUsers.Rows[e.RowIndex];
            var value = row.Cells[0].Value.ToString();
            var user = await _serviceManager.UserService.GetUserByIdAsync(value!);

            if (user != null)
            {
                lblGuid.Text = user.Id!;
                txtFirstName.Text = user.FirstName!;
                txtLastName.Text = user.LastName!;
                txtEmail.Text = user.Email!;
                cbUserType.SelectedIndex = (int)user.UserType;
                cbEnabled.Checked = user.Enabled;
            }

            ResetButtons(false, true, true);
        }

        private void ResetForm()
        {
            lblGuid.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            cbUserType.SelectedIndex = 0;
            cbEnabled.Checked = false;
        }

        private void ResetButtons(bool add, bool update, bool setnew)
        {
            btnAdd.Enabled = add;
            btnNew.Enabled = update;
            btnUpdate.Enabled = setnew;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var dto = new UserForRegistrationDto
            {
                Email = txtEmail.Text,
                Enabled = cbEnabled.Checked,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text,
                RepeatPassword = txtPassword.Text,
                UserType = (UserType)cbUserType.SelectedIndex
            };

            var result = await _serviceManager.UserService.CreateUser(dto);

            if (result.Succeeded)
            {
                await LoadUsers();
                ResetForm();
                ResetButtons(true, false, false);
            }
            else
            {
                var errors = "";

                foreach (var error in result.Errors)
                    errors += $"{error.Code}: {error.Description}\n";

                MessageBox.Show($"Se encontraron los siguientes errores: \n{errors}");
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var dto = new UserUpdateDto
            {
                Email = txtEmail.Text,
                Enabled = cbEnabled.Checked,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text,
                UserType = (UserType)cbUserType.SelectedIndex
            };

            var result = await _serviceManager.UserService.UpdateUserAsync(dto);

            if (result.Succeeded)
            {
                await LoadUsers();
                ResetForm();
                ResetButtons(true, false, false);
            }
            else
            {
                var errors = "";

                foreach (var error in result.Errors)
                    errors += $"{error.Code}: {error.Description}\n";

                MessageBox.Show($"Se encontraron los siguientes errores: \n{errors}");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
            ResetButtons(true, false, false);
        }

        private async Task LoadUsers()
        {
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Nombres", typeof(string));
                dt.Columns.Add("Apellidos", typeof(string));
                dt.Columns.Add("Correo Electronico", typeof(string));
                dt.Columns.Add("Usuario", typeof(string));
            }

            var users = await _serviceManager.UserService.GetAllUsersAsync(new RequestParameters(), false);

            if (dt.Rows.Count > 0)
                dt.Rows.Clear();

            foreach (var user in users)
            {
                DataRow row = dt.NewRow();
                row["ID"] = user.Id!;
                row["Nombres"] = user.FirstName!;
                row["Apellidos"] = user.LastName!;
                row["Correo Electronico"] = user.Email!;
                row["Usuario"] = user.UserName!;

                dt.Rows.Add(row);
            }

            dgUsers.DataSource = dt;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
