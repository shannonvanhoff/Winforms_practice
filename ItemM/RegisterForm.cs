using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemM.Models;
using ItemM.Repository;

namespace ItemM
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = tbUsername.Text,
                Password = tbPassword.Text // Note: Hash passwords in production
            };

            var repo = new UserRepository();
            repo.RegisterUser(user);

            MessageBox.Show("Registration successful!");
            this.Close();
        }
    }
}
