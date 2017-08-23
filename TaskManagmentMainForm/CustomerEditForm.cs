using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TaskManagmentMainForm
{
    public partial class CustomerEditForm : Form
    {
        Employee _user;
        Customer _customer;
        CustomerBusiness _cusBLL;
        CustomerEmployeeBusiness _cusEmpBLL;
        List<CustomerEmployee> cusEmpList;
        public CustomerEditForm()
        {
            InitializeComponent();
            _customer = new Customer();
        }

        public CustomerEditForm(Customer cust)
        {
            InitializeComponent();
            _customer = cust;
            txtCustomerID.Text = _customer.ID.ToString();
            txtCompanyName.Text = _customer.CompanyName;
            txtCountry.Text = _customer.Country;
            txtCity.Text = _customer.City;
            txtAdress.Text = _customer.Address;
            dgvCustomerEmployee.DataSource = _customer.Contacts;
        }
        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            RefreshCustomerEmployee();
            MainForm mainform = (MainForm)this.MdiParent;
            _user=mainform.GetUser();
            _cusBLL = new CustomerBusiness(_user);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.CompanyName = txtCompanyName.Text;
                _customer.Country = txtCountry.Text;
                _customer.City = txtCity.Text;
                _customer.Address = txtAdress.Text;
                _cusBLL.Add(_customer);
                MessageBox.Show("Müşteri eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri eklenemedi.");
            }
        }
        private void btnSaveCustomerEmployee_Click(object sender, EventArgs e)
        {
            CustomerEmployeeEditForm editForm = new CustomerEmployeeEditForm(_customer);
            editForm.MdiParent = this.MdiParent;
            editForm.Show();
        }
        private void dgvCustomerEmployee_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            dgvCustomerEmployee.SelectedRows[0].Selected = true;
        }
        private void RefreshCustomerEmployee()
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            _user = mainForm.GetUser();

            _cusEmpBLL = new CustomerEmployeeBusiness(_user);
            try
            {
                cusEmpList = _cusEmpBLL.GetCusEmpByCustomer(_customer.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvCustomerEmployee.DataSource = cusEmpList;
        }
        private void cmiUpdateCustomerEmployee_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dgvCustomerEmployee.Rows[0].Cells["ID"].Value;
            CustomerEmployee cusEmp = _cusEmpBLL.Get(selectedID);
            CustomerEmployeeEditForm editForm = new CustomerEmployeeEditForm(cusEmp, _customer);
            editForm.MdiParent = this.MdiParent;
            editForm.Show();
        }
        private void cmiDeleteCustomerEmployee_Click(object sender, EventArgs e)
        {
            if(dgvCustomerEmployee.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili çalışanı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int selectedID = (int)dgvCustomerEmployee.Rows[0].Cells["ID"].Value;
                        CustomerEmployee cusEmp = _cusEmpBLL.Get(selectedID);
                        _cusEmpBLL.Remove(cusEmp);
                    }
                    catch
                    {
                        MessageBox.Show("Silme işlemi gerçekleşmedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }
        }
    }
}
