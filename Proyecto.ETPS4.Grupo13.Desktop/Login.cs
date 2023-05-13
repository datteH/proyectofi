using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Service.Contracts;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public partial class Login : Form
    {
        private readonly IServiceManager _serviceManager;
        private UserSession _userSession;
        public Login(IServiceManager serviceManager, UserSession userSession)
        {
            _serviceManager = serviceManager;
            _userSession = userSession;
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var dto = new UserForAuthenticationDto
                {
                    RememberMe = true,
                    Password = txtPassword.Text,
                    Username = txtEmail.Text,
                };

                if (!await _serviceManager.AuthenticationService.ValidateUser(dto))
                    MessageBox.Show("Neles, no sos usuario");
                else
                {
                    _userSession.User = await _serviceManager.AuthenticationService.GetUserAsync(txtEmail.Text);
                    var main = new Main(_serviceManager, _userSession);
                    main.Show();

                    this.Hide();
                }
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errProvider.SetError(txtEmail, "Debe escribir un correo electrónico");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errProvider.SetError(txtPassword, "Debe escribir su clave");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtPassword, "");
            }
        }
    }
}