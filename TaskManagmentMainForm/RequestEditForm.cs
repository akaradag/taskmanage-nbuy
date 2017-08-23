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
    public partial class RequestEditForm : Form
    {
        ProjectBusiness _projectBLL;
        RequestTypeBusiness _reqTypeBLL;
        RequestBusiness _reqBLL;
        Request _req;
        Employee _user; 
        private int _projectId;

       
        public RequestEditForm(int projectId)
        {
            InitializeComponent();
            this._projectId = projectId;
            _req = new Request();
        }

        private void RequestEditForm_Load(object sender, EventArgs e)
        {
            
            MainForm mainForm = (MainForm)this.MdiParent;
            _user = mainForm.GetUser();
            _reqTypeBLL = new RequestTypeBusiness(_user);

            _projectBLL = new ProjectBusiness(_user);
            Project project = _projectBLL.Get(_projectId);
            txtProject.Text = project.Name;

           List<RequestType> reqType = _reqTypeBLL.GetAll();
           cmbRequestType.DataSource = null;
           cmbRequestType.DataSource = reqType;
            cmbRequestType.ValueMember = "ID";
            cmbRequestType.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _reqBLL = new RequestBusiness(_user);
            _req.ProjectID = _projectId;
            _req.Description = txtDescription.Text;
            _req.RecievedDate = dtpRecievedDate.Value;
            _req.RequestTypeID = (int)cmbRequestType.SelectedValue;
           

            bool result = false;
            try
            {
                result = _reqBLL.Add(_req);  
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show((result) ? "İstek eklendi." : "İstek eklenemedi.");
        }
    }
}
