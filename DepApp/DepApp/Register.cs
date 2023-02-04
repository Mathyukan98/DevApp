using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //import the utility

namespace DepApp
{
    public partial class Register : Form
    {
        DepartmentDBDataContext _context = new DepartmentDBDataContext();
        public Register()
        {
           
            InitializeComponent(); 
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var chkUser = _context.Logins.Where(u => u.Username.Equals(txtBoxUserName.Text)).FirstOrDefault();
           

            if (chkUser == null )
            {


                if (txtBoxPassword.Text.Equals(txtBoxCnfrmPWord.Text) && String.IsNullOrEmpty(txtBoxUserName.Text) && String.IsNullOrEmpty(txtBoxPassword.Text) && String.IsNullOrEmpty(comboBoxDesignation.Text))
                {

                    Login newlogin = new Login();

                    newlogin.Name = txtBoxName.Text;
                    newlogin.Username = txtBoxUserName.Text;
                    newlogin.Password = txtBoxPassword.Text;
                    newlogin.Designation = comboBoxDesignation.Text;
                    newlogin.Email = txtBoxEmail.Text;
                    try
                    {
                        _context.Logins.InsertOnSubmit(newlogin);
                        _context.SubmitChanges();
                        MessageBox.Show("Successfully Registered!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    var login = (LoginForm)Application.OpenForms["LoginForm"];
                    if (login != null)
                    {
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        login = new LoginForm();
                        login.Show();
                        this.Hide();

                    }
                }
                else {
                    MessageBox.Show("Fill all the fields!");
                
                }
            }
            else
            {
                MessageBox.Show("Username not available");

            }




        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm ob = new LoginForm();
            ob.Show();
        }

        private void txtBoxEmail_Validated(object sender, EventArgs e)
        {
            
                if (Regex.IsMatch(txtBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)(\.(\w){2,3})+$"))
                {
                    errorProvider1.SetError(txtBoxEmail, "");
                }
          
           else{  
                errorProvider1.SetError(txtBoxEmail, "Invalid Email Address ");

            }
        }

        private void textBoxAge_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxAge.Text, @"^\d{1,2}$"))
            {
                errorProvider1.SetError(textBoxAge, "");
            }

            else
            {
                errorProvider1.SetError(textBoxAge, "Invalid Age ");

            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
