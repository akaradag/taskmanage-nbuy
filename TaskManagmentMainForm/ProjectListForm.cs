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
    public partial class ProjectListForm : Form
    {
        private Employee _user;

        public ProjectListForm()
        {
            InitializeComponent();
        }

        private void ProjectListForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.MdiParent as MainForm;
            _user = mainForm.GetUser();
            RefreshDGV();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(filter))
            {
                ProjectBusiness projectBuss = new ProjectBusiness(_user);
                dgvProject.DataSource = null;
                try
                {
                    dgvProject.DataSource = projectBuss.GetAllFiltered(filter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void RefreshDGV()
        {
            ProjectBusiness projectBuss = new ProjectBusiness(_user);
            dgvProject.DataSource = null;
            try
            {
                dgvProject.DataSource = projectBuss.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region context menu events

        private void dgvProject_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (_user.RoleID == 1)
            {
                e.ContextMenuStrip = cmsManager;
            }
            else if (_user.RoleID == 2 || _user.RoleID == 3)
            {
                e.ContextMenuStrip = cmsLeaderAnalist;
            }
            dgvProject.Rows[e.RowIndex].Selected = true;
         
        }
        private void miTaskList_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvProject.SelectedRows[0].Cells["ID"].Value;

                TaskListForm tlForm = new TaskListForm(projectId);
                tlForm.MdiParent = this.MdiParent;
                tlForm.Show();
            }
        }
        private void miEditProject_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvProject.SelectedRows[0].Cells["ID"].Value;

                ProjectEditForm pEditForm = new ProjectEditForm(projectId);
                pEditForm.MdiParent = this.MdiParent;
                pEditForm.Show();
            }
        }

        private void miDeleteProject_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvProject.SelectedRows[0].Cells["ID"].Value;
                string projectName = (string)dgvProject.SelectedRows[0].Cells["Name"].Value;

                DialogResult result = MessageBox.Show(string.Format("{0} isimli projeyi silmek istediğinize emin misiniz?", projectName), "Dikkat!", MessageBoxButtons.YesNo);

                bool removeResult = false;
                if (result == DialogResult.Yes)
                {
                    ProjectBusiness projectBuss = new ProjectBusiness(_user);
                    try
                    {
                        removeResult = projectBuss.Remove(projectBuss.Get(projectId));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show(removeResult ? "Silme işlemi başarıyla gerçekleşti." : "Silme işlemi başarısız!");
                }
            }
        }

        private void miAddTask_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvProject.SelectedRows[0].Cells["ID"].Value;

                TaskEditForm tEditForm = new TaskEditForm(projectId);
                tEditForm.MdiParent = this.MdiParent;
                tEditForm.Show();
            }
        }

        private void miRequestList_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvProject.SelectedRows[0].Cells["ID"].Value;

                RequestListForm rListForm = new RequestListForm(projectId);
                rListForm.MdiParent = this.MdiParent;
                rListForm.Show();
            }
        }

        private void miAddRequest_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                int projectId = (int)dgvProject.SelectedRows[0].Cells["ID"].Value;

                RequestEditForm rEditForm = new RequestEditForm(projectId);
                rEditForm.MdiParent = this.MdiParent;
                rEditForm.Show();
            }
        }
        #endregion


    }
}
