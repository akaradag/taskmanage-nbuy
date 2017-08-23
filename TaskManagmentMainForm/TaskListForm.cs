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
    public partial class TaskListForm : Form
    {
        private int _taskID;
        private int _projectId;
        Employee _user;
        //
        public TaskListForm()
        {
        }

        public TaskListForm(int projectId)
        {
            InitializeComponent();
            this._projectId = projectId;
        }

        private void TaskListForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.MdiParent as MainForm;
            _user = mainForm.GetUser();
            RefreshDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(filter))
            {
                TaskLogBusiness taskLogBussiness = new TaskLogBusiness();
                dgvTask.DataSource = null;
                try
                {
                    dgvTask.DataSource = taskLogBussiness.GetAllFiltered(filter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        public void RefreshDGV()
        {
            TaskLogBusiness taskLogBussiness = new TaskLogBusiness();
            dgvTask.DataSource = null;
            try
            {
                dgvTask.DataSource = taskLogBussiness.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTask_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0)
            {
                dgvTask.Rows[e.RowIndex].Selected = true;
                _taskID = (int)dgvTask.Rows[e.RowIndex].Cells["TaskID"].Value;
                dgvTask.ContextMenuStrip = cmsTask;
            }
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0)
            {
                TaskEditForm taskEditForm = new TaskEditForm(_taskID, _projectId);
                taskEditForm.MdiParent = this.MdiParent;
                taskEditForm.Show();
            }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0)
            {
                TaskBusiness taskBuss = new TaskBusiness(_user);
                bool result = false;
                try
                {
                    result = taskBuss.Remove(taskBuss.Get(_taskID));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(result ? "İşlem başarılı" : "İşlem başarısız");
            }
        }



    }
}
