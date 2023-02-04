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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm ob = new LoginForm();
            ob.Show();

        }

        private void btCreateAcc_Click(object sender, EventArgs e)
        {
            Register ob = new Register();
            ob.Show();
        }
    }
}
