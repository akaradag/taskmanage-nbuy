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
    public partial class RequestListForm : Form
    {
        Employee _user;
        RequestBusiness _reqBLL;
        private int projectId;
        

        public RequestListForm()
        {
            InitializeComponent();
        }

        public RequestListForm(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
        }

        private void RequestListForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            _user = mainForm.GetUser();
            RefreshRequests();

        }

        private void RefreshRequests()
        {
            _reqBLL = new RequestBusiness(_user);
            dgvRequests.DataSource = null;
            try
            {
                dgvRequests.DataSource = _reqBLL.GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string input = txtRequestInput.Text;
            if(input != null)
            {
                _reqBLL = new RequestBusiness(_user);
                dgvRequests.DataSource = null;
                try
                {
                    dgvRequests.DataSource = _reqBLL.GetAllFiltered(input);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                RefreshRequests();
            }
        }

        // Context Menu
        private void dgvRequests_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            dgvRequests.Rows[e.RowIndex].Selected = true;
        }

        private void cmiUpdateRequest_Click(object sender, EventArgs e)
        {
            if(dgvRequests.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvRequests.Rows[0].Cells["ProjectID"].Value;
                RequestEditForm editForm = new RequestEditForm(projectId);
                editForm.MdiParent = this.MdiParent;
                editForm.Show();
            }
            
        }

        private void cmiDeleteRequest_Click(object sender, EventArgs e)
        {
            if(dgvRequests.SelectedRows.Count > 0)
            {
                bool isDeleted = false;
                int projectId = (int)dgvRequests.Rows[0].Cells["ProjectID"].Value;
                DialogResult result = MessageBox.Show("Bu isteği silmek istediğinizden emin misiniz?","Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    _reqBLL = new RequestBusiness(_user);
                    Request deleteRequest = _reqBLL.Get(projectId);
                    try
                    {
                        _reqBLL.Remove(deleteRequest);
                        isDeleted = true;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show(isDeleted ? "Seçilen istek silindi." : "Seçilen istek silinemedi.");
                }

            }
        }
    }
}
