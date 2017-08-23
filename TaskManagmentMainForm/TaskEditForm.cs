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
    public partial class TaskEditForm : Form
    {
        private int _taskID = -1;
        private int _projectId;
        private Employee _user;
        private Entity.Task _task;
        TaskBusiness _taskBuss;

        public TaskEditForm(int projectId)
        {
            InitializeComponent();
            this._projectId = projectId;
            _task = new Entity.Task();
        }

        public TaskEditForm(int taskID, int projectId)
        {
            InitializeComponent();
            this._taskID = taskID;
            this._projectId = projectId;
        }

        private void TaskEditForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.MdiParent as MainForm;
            _user = mainForm.GetUser();

            if (_taskID > 0)
            {
                _taskBuss = new TaskBusiness(_user);
                _task = _taskBuss.Get(_taskID);

                lblID.Text = _taskID.ToString();
                txtDescription.Text = _task.Description;
            }
            FillComboBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _task.Description = txtDescription.Text;
            _task.ProjectID = _projectId;

            TaskLog taskLog = new TaskLog();
            taskLog.TaskDate = DateTime.Now;
            taskLog.TaskStatusID = (int)cmbTaskStatus.SelectedValue;
            
            if (taskLog.TaskStatusID != 1)
            {
                taskLog.EmployeeID = (int)cmbTaskEmployee.SelectedValue;
            }

            if (_taskID < 0)
            {
                _task.CreatedDate = DateTime.Now;
            }

            _task.TaskLogs.Add(taskLog);

            bool result = false;
            try
            {
                result = (_taskID < 0) ? _taskBuss.Add(_task) : _taskBuss.Update(_task);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "İşlem başarılı" : "İşlem başarısız");
            this.Close();
        }

        private void FillComboBoxes()
        {
            EmployeeBusiness empBuss = new EmployeeBusiness(_user);
            List<Employee> empList = new List<Employee>();
            if (_user.RoleID == 2)
            {
                empList = empBuss.GetByRole(3);
                empList.AddRange(empBuss.GetByRole(4));
                empList.AddRange(empBuss.GetByRole(5));
            }
            else if (_user.RoleID == 3)
            {
                empList = empBuss.GetByRole(4);
                empList.AddRange(empBuss.GetByRole(5));
            }
            cmbTaskEmployee.DataSource = empList;
            cmbTaskEmployee.ValueMember = "ID";
            cmbTaskEmployee.DisplayMember = "FullNameRole";

            TaskStatusBusiness tsBuss = new TaskStatusBusiness();
            cmbTaskStatus.DataSource = tsBuss.GetAll();
            cmbTaskStatus.DisplayMember = "Name";
            cmbTaskStatus.ValueMember = "ID";

            if (_taskID > 0)
            {
                Employee taskEmp = empBuss.GetByTaskId(_taskID);
                if (taskEmp != null)
                {
                    cmbTaskEmployee.SelectedIndex = cmbTaskEmployee.FindStringExact(taskEmp.FullNameRole);
                }

                cmbTaskStatus.SelectedIndex = cmbTaskStatus.FindStringExact(tsBuss.GetLastStatusOfTask(_taskID).Name);
            }
        }
    }
}
