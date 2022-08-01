using FirstFormApp.Services;

namespace FirstFormApp
{
    public partial class Form1 : Form
    {
        AuthManager _authManager = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            var txtEmail = Txtemail.Text;
            var txtPassword = Txtpassword.Text;
            var user = _authManager.Login(txtEmail, txtPassword);

            if(user != null)
            {
                Dashboard dashboard = new Dashboard();

                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ve ya sifre sehvdir", "Diqqet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            Register register = new();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new();
            category.ShowDialog();
        }
    }
}