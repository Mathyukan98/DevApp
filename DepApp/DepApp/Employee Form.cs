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
    public partial class Employee_Form : Form
    {
        DepartmentDBDataContext _context;
        public Employee_Form()
        {
            InitializeComponent();
            _context = new DepartmentDBDataContext();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            var employee = new Employee();


            /* if (!string.IsNullOrEmpty(txtName.Text))
             {                
                 employee.Name = txtName.Text;               
                 employee.Address = txtAddress.Text;
                 employee.Gender = txtGender.Text;
                 employee.Phone = txtPhone.Text;

                 _context.Employees.InsertOnSubmit(newEmployee);
                 _context.SubmitChanges();
             }*/

            employee.Name = txtName.Text;
            employee.Address = txtAddress.Text;
            employee.Gender = txtGender.Text;
            employee.Phone = txtPhone.Text;
            employee.Email = txtBoxEmail.Text;
            employee.Department = comboBoxDep.Text;

            try
            {
                _context.Employees.InsertOnSubmit(employee);
                _context.SubmitChanges();
                MessageBox.Show("Data Added Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed :" + ex.Message);
            }

        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            List<Employee> emp = _context.Employees.ToList();
            dgvViewEmp.DataSource = emp;
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main ob = new Main();
            ob.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main ob = new Main();
            ob.Show();
            this.Hide();
        }

        private void btnFilterEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
