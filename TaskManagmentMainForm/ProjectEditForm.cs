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
    public partial class ProjectEditForm : Form
    {
        private int _projectId = -1;
        Employee _user;
        Project _project;
        ProjectBusiness _pBuss;

        public ProjectEditForm()
        {
            InitializeComponent();
            _project = new Project();
        }

        public ProjectEditForm(int projectId)
        {
            InitializeComponent();
            this._projectId = projectId;
        }

        private void ProjectEditForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.MdiParent as MainForm;
            _user = mainForm.GetUser();
            FormControlsLoad();
        }

        private void FormControlsLoad()
        {
            _pBuss = new ProjectBusiness(_user);
            if (_projectId > 0)
            {
                try
                {
                    _project = _pBuss.Get(_projectId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtName.Text = _project.Name;
                dtpEndDate.Value = _project.EndDate;
                dtpStartDate.Value = _project.StartDate;
            }

            CustomerBusiness custBuss = new CustomerBusiness(_user);

            cmbCustomer.DataSource = null;
            cmbCustomer.DataSource = custBuss.GetAll();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "ID";
            if (_projectId > 0)
            {
                cmbCustomer.SelectedValue = _project.Customer.ID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _project.CustomerID = (int)cmbCustomer.SelectedValue;
            _project.Name = txtName.Text;
            _project.StartDate = dtpStartDate.Value;
            _project.EndDate = dtpEndDate.Value;

            bool result = false;
            try
            {
                if(_projectId > 0)
                {
                    result=_pBuss.Update(_project);
                }
                else
                {
                    result=_pBuss.Add(_project);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show((result) ? "İşlem başarılı": "İşlem başarısız");

            this.Close();
        }
    }
}
