namespace ThirdColloc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Navigate to the login window
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close the current window (if needed)
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Navigate to the login window
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            // Close the current window (if needed)
            this.Hide();
        }
    }
}