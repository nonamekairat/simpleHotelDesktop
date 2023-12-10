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
    public partial class LoginForm : Form
    {

        UserService _service;
        public LoginForm()
        {
            _service = new UserService();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            User user = _service.LoginUser(username, password);
            if (user == null)
            {
                // add error labels
            }
            else if(user.Role == Roles.Administrator.ToString())
            {
                AdministratorForm administratorForm = new AdministratorForm();
                administratorForm.Show();

                this.Hide();
            }
            else if(user.Role == Roles.Reception.ToString())
            {
                ReceptionForm receptionForm = new ReceptionForm();
                receptionForm.Show();

                this.Hide();
            }
            else if(user.Role == Roles.Client.ToString())
            {
                ClientForm clientForm = new ClientForm();
                clientForm.Show();  

                this.Hide();
            }
            else
            {
                // wow, something really bad happened
            }
            
        }
    }
}
