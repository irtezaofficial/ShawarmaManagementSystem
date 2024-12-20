namespace ShawarmaManagementSystem
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        private readonly IDatabaseAdapter _databaseAdapter;
        public Login()
        {
            InitializeComponent();
            _databaseAdapter = new DatabaseAdaptee();
            _loginService = new LoginProxy(new LoginService(_databaseAdapter));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Text;

            try
            {
                var user = _loginService.Login(userName, password);
                if (user is not null)
                {
                    if (user.Type == UserType.Admin)
                    {
                        MessageBox.Show("Login Successfully As Admin..");
                        AdminDashboard panel = new();
                        panel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Successfully As User..");
                        OrderForm panel = new OrderForm();
                        panel.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserName.Clear();
                    Password.Clear();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
