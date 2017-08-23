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
using BLL;

namespace TaskManagmentMainForm
{
    public partial class MainForm : Form
    {
        Employee _user;

        public MainForm()
        {
            InitializeComponent();
        }

        public Employee GetUser()
        {
            return _user;
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // LogIn kontrol
            EmployeeBusiness _empBussiness = new EmployeeBusiness(_user);
            try
            {
                _user = _empBussiness.GetByLogIn(txtMail.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtMail.Text = default(string);
            txtPassword.Text = default(string);
            if (_user != null)
            {
                // msler role göre gelicek.
                if (_user.RoleID == 1)
                {
                    msManager.Visible = true;
                }
                else if (_user.RoleID == 2 || _user.RoleID == 3)
                {
                    msLeaderAnalist.Visible = true;
                }
                else if (_user.RoleID == 4 || _user.RoleID == 5)
                {
                    msDevTest.Visible = true;
                }

                // Hi Panel 

                pnlLogIn.Visible = false;
                pnlHi.Visible = true;
                lblHi.Text = string.Format("Hoşgeldin\n{0} {1}", _user.FirstName, _user.LastName);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            msDevTest.Visible = false;
            msLeaderAnalist.Visible = false;
            msManager.Visible = false;

            lblHi.Text = default(string);

            pnlHi.Visible = false;
            pnlLogIn.Visible = true;

            _user = null;

            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
        }

        #region Kontrollü MdiChild Aç
        public void OpenControlledMdiChild<TForm>() where TForm : Form, new()
        {
            bool formFound = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is TForm)
                {
                    form.BringToFront();
                    formFound = true;
                    break;
                }
            }
            if (!formFound)
            {
                TForm form = new TForm();
                form.MdiParent = this;
                form.Show();
            }
        }
        #endregion

        #region Menu Item Click Events
        private void miProjectEdit_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<ProjectEditForm>();
        }

        private void miProjectList_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<ProjectListForm>();
        }

        private void miEmployeeEdit_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<EmployeeEditForm>();
        }

        private void miEmployeeList_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<EmployeeListForm>();
        }

        private void miCustomerEdit_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<CustomerEditForm>();
        }

        private void miCustomerList_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<CustomerListForm>();
        }

        private void miTaskList_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<TaskListForm>();
        }

        private void miMyTasks_Click(object sender, EventArgs e)
        {
            OpenControlledMdiChild<MyTasksForm>();
        }


        #endregion

      
    }

}
