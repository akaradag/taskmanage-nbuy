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
    public partial class EmployeeEditForm : Form
    {
        EmployeeBusiness _empBLL;
        RoleBusiness _roleBLL;
        Employee _emp;
        Employee _user;
        private int _selectedId;

        public EmployeeEditForm()
        {
            InitializeComponent();
            _emp = new Employee();
            _empBLL = new EmployeeBusiness(_user);
            
        }

        public EmployeeEditForm(int _selectedID)
        {
            InitializeComponent();
            this._selectedId = _selectedID;
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            _user = mainForm.GetUser();

            FillForm();
            //FillRoleCmb();

        }

        private void FillForm()
        {
            _empBLL = new EmployeeBusiness(_user);
            if(_selectedId > 0)
            {
                try
                {
                    _emp = _empBLL.Get(_selectedId);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtID .Text= _emp.ID.ToString();
                txtFirstName.Text = _emp.FirstName;
                txtLastName.Text = _emp.LastName;
                txtEmail.Text = _emp.Email;
                txtPassword.Text = _emp.Password;

            }

            FillRoleCmb();
         }


        private void FillRoleCmb()
        {
           
            _roleBLL = new RoleBusiness(_user);

            cmbRoleID.DataSource = null;
            cmbRoleID.DataSource = _roleBLL.GetAll();
            cmbRoleID.DisplayMember = "Name";
            cmbRoleID.ValueMember = "ID";

            if(_selectedId > 0)
            {
                int roleInt = Convert.ToInt32(_emp.RoleID);
                Role empRole = _roleBLL.Get(roleInt);
                cmbRoleID.SelectedItem = empRole;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _empBLL = new EmployeeBusiness(_user);

            if (true)
            {
                
            }
                    _emp.FirstName = txtFirstName.Text;
                    _emp.LastName = txtLastName.Text;
                    _emp.BirthDate = dtpBirthDate.Value;
                    _emp.HireDate = dtpHireDate.Value;
                    _emp.Email = txtEmail.Text;
                    _emp.Password = txtPassword.Text;
                    _emp.RoleID = (int)cmbRoleID.SelectedValue;
                    
            try
            {
                if (_selectedId > 0)
                {
                    _empBLL.Update(_emp);
                    MessageBox.Show("Güncelleme başarılı.");
                }
                else
                {
                    _empBLL.Add(_emp);
                    MessageBox.Show("Kayıt işlemi başarılı.");
                }
            }
            catch (Exception ex )
            {
                 MessageBox.Show(ex.Message);
            }
        }

      
    }
}
