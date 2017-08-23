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
    
    public partial class EmployeeListForm : Form
    {
        EmployeeBusiness _empBLL;
        Employee _user;
        private int _selectedID;
        
        public EmployeeListForm()
        {
            InitializeComponent();
            
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        { 
            MainForm mainForm = (MainForm)this.MdiParent;
            _user = mainForm.GetUser();
            RefreshEmployeeList();
        }
        
        private void RefreshEmployeeList()
        {
            _empBLL = new EmployeeBusiness(_user);
            dgvEmployees.DataSource = null;

            try
            {
                dgvEmployees.DataSource = _empBLL.GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvEmployeeList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            dgvEmployees.Rows[e.RowIndex].Selected = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string input = txtFirstName.Text;
            List<Employee> empList = _empBLL.GetAll();


            if(input != string.Empty)
            {
                List<Employee> filterList = new List<Employee>();
                foreach (Employee emp in empList)
                {
                    string fullName = emp.ToString();
                    if(fullName.Contains(input))
                    {
                        filterList.Add(emp);
                    }
                }

                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = filterList;
            }
            else
            {
                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = empList;
            }
        }


        //  Context
        private void cmiUpdateEmployee_Click(object sender, EventArgs e)
        {
            
                if(dgvEmployees.SelectedRows.Count > 0)
                {
                    _selectedID = (int)dgvEmployees.SelectedRows[0].Cells["ID"].Value;
                   
                    EmployeeEditForm editForm = new EmployeeEditForm(_selectedID);
                    editForm.MdiParent = this.MdiParent;
                    editForm.Show();
                }
           
        }

        private void cmiDeleteEmployee_Click(object sender, EventArgs e)
        {
            if(dgvEmployees.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçilen çalışanı silmek istediğinizden emin misniz?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    _selectedID = (int)dgvEmployees.SelectedRows[0].Cells["ID"].Value;
                    Employee emp = _empBLL.Get(_selectedID);
                    _empBLL.Remove(emp);
                 
                }
            }
        }

       
    }




}
