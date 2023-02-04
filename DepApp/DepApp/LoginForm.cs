using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepApp
{
    public partial class LoginForm : Form
    {
        DepartmentDBDataContext _context = new DepartmentDBDataContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _context.Logins.Where(u => u.Username.Equals(txtBoxUserName.Text) && u.Password.Equals(txtBoxPassword.Text)).FirstOrDefault();
            if (user != null)
            {
                if (user.Designation == "Admin")
                {
                    Employee_Form ob = new Employee_Form();
                    ob.Show();
                }
                else
                {
                    LMS ob = new LMS();
                    ob.Show();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or Password is invalid!");
            }
        }

        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register ob = new Register();
            ob.Show();
        }
    }
}
