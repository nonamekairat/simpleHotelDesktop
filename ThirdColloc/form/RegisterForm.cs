using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdColloc.Models;
using ThirdColloc.Service;

namespace ThirdColloc
{
    public partial class RegisterForm : Form
    {

        UserService _service;
        string type;
        public RegisterForm(string type)
        {
            this.type = type;
            _service = new UserService();
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;

            if (!(password == confirmPassword))
            {
                // add labels that passwords don't match
                return;
            }
            if (_service.GetUserByUsername(username) != null)
            {
                // add labels that username is already exists
                return;
            }



            User user = new User(username, password, type);
            // make it for reception also later

            _service.RegisterUser(user);

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();

        }
    }
}
