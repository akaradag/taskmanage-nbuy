using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace TaskManagmentMainForm
{
    public partial class CustomerEmployeeEditForm : Form
    {

        Customer _customer;
        CustomerEmployee _cusEmp;
        Employee _user;
        CustomerEmployeeBusiness _cusEmpBLL;
        

        public CustomerEmployeeEditForm(Customer customer)
        {
            InitializeComponent();
            this._customer = customer;
            txtCustomerID.Text = _customer.ID.ToString();
            
            
        }

        public CustomerEmployeeEditForm(CustomerEmployee cusEmp, Customer _customer)
        {
            InitializeComponent();
            this._cusEmp = cusEmp;
            this._customer = _customer;

            
            txtFirstName.Text = _cusEmp.FirstName;
            txtLastName.Text = _cusEmp.LastName;
            txtCustomerID.Text = _customer.ID.ToString();
            txtPhone.Text = _cusEmp.Phone;

        }

        private void CustomerEmployeeEditForm_Load(object sender, EventArgs e)
        {
            _customer = new Customer();
            _cusEmp = new CustomerEmployee();


        }
        private void btnSaveCustomerEmployee_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            _user = mainForm.GetUser();

            _cusEmpBLL = new CustomerEmployeeBusiness(_user);
            bool result = false;
            try
            {
                
                if(_cusEmp.ID < 1)
                {                   
                    _cusEmp.FirstName = txtFirstName.Text;
                    _cusEmp.LastName = txtLastName.Text;
                    _cusEmp.CustomerID = Convert.ToInt32(_customer.ID);
                    _cusEmp.Phone = txtPhone.Text;

                    result = _cusEmpBLL.Add(_cusEmp);
                   

                }
                else
                {
                    _cusEmp.ID = Convert.ToInt32(txtID.Text);
                    _cusEmp.FirstName = txtFirstName.Text;
                    _cusEmp.LastName = txtLastName.Text;
                    _cusEmp.CustomerID = Convert.ToInt32(txtCustomerID);
                    _cusEmp.Phone = txtPhone.Text;

                    _cusEmpBLL.Update(_cusEmp);
                }
             }
            catch (Exception)
            {
                MessageBox.Show("İşlem başarısız oldu.");
            }
            MessageBox.Show((result)? "Müşteri çalışanı eklendi." : "Müşteri çalışanı eklenemedi");
        }

       

     
    }
}
