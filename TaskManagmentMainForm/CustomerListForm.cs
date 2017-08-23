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
    public partial class CustomerListForm : Form
    {
        
       
      private  Employee _user;
        CustomerBusiness _cusBLL;
        

        
        public CustomerListForm()
        {
            InitializeComponent();
         
           
        }
  
        private void CustomerListForm_Load(object sender, EventArgs e)
        {




            MainForm mainform = this.MdiParent as MainForm;
            _user = mainform.GetUser();
            RefreshDGV();

        }
        public void RefreshDGV()
        {
            CustomerBusiness cbusiness = new CustomerBusiness(_user);
            dgvCustomerList.DataSource = null;
            try
            {
                dgvCustomerList.DataSource = cbusiness.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void dgvCustomerList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (_user.RoleID==1)
            {
                e.ContextMenuStrip = contextMenuStrip1;

            }          
            dgvCustomerList.Rows[e.RowIndex].Selected = true;

        }

        private void cmsCustomerRefresf_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count >0 )
            {
                int customerID = (int)dgvCustomerList.SelectedRows[0].Cells["ID"].Value;
                //Buraya tekrar bakılacak.....

                _cusBLL = new CustomerBusiness(_user);
                Customer cust =  _cusBLL.Get(customerID);
                CustomerEditForm customerEditForm = new CustomerEditForm(cust);
                customerEditForm.MdiParent = this.MdiParent;
                customerEditForm.Show();
            }




        }
        private void cmiCustomerDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count > 0)
            {
                int customerID = (int)dgvCustomerList.SelectedRows[0].Cells["ID"].Value;
                string companyName = (string)dgvCustomerList.SelectedRows[0].Cells["CompanyName"].Value;
                DialogResult result = MessageBox.Show(string.Format("{0} ismindeki şireketi müşteri listesinden"
                    + " silmek istediginizden eminmisiniz", companyName), "Dikkat", MessageBoxButtons.YesNo);
                bool removeResult = false;
                if (result == DialogResult.Yes)
                {
                    CustomerBusiness custB = new CustomerBusiness(_user);
                    try
                    {
                        removeResult = custB.Remove(custB.Get(customerID));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show(removeResult ? "Silme İşlemi Başrıyla Gerçekleşti" : "Silme İşlemi Başarısız");
                }
            }
        }

        private void btnCustomerListRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void btnFilterCompanyName_Click(object sender, EventArgs e)
        {

            string filter = txtSorch.Text.Trim();
            if (!string.IsNullOrEmpty(filter))
            {
                CustomerBusiness custBusiness = new CustomerBusiness(_user);
                dgvCustomerList.DataSource = null;
                try
                {
                    dgvCustomerList.DataSource = custBusiness.GetFilteredCustomer(filter);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }



        }
    }
}
