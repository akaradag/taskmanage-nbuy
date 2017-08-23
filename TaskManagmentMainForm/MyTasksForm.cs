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
    public partial class MyTasksForm : Form
    {
        Employee _user;
        Label _draggingLabel;

        public MyTasksForm()
        {
            InitializeComponent();
        }

        private void MyTasksForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.MdiParent as MainForm;
            _user = mainForm.GetUser();
            FillContainers();
        }

        private void FillContainers()
        {
            TaskLogBusiness taskLogBuss = new TaskLogBusiness();
            List<TaskLog> tlList = taskLogBuss.GetAllByEmployeeId(_user.ID);
            foreach (TaskLog item in tlList)
            {
                string lblText = string.Format("Görev: {0}\nOluşturulma tarihi: {1}\nDurum tarihi: {2}", item.Task.Description, item.TaskDate, item.Task.CreatedDate);
                Label lbl = CreateLabel(lblText, (int)item.TaskID);
                if (item.TaskStatusID == 2)
                {
                    flpAssigned.Controls.Add(lbl);
                }
                if (item.TaskStatusID == 3 || item.TaskStatusID == 5)
                {
                    flpInProgress.Controls.Add(lbl);
                }
                if (item.TaskStatusID == 4 || item.TaskStatusID == 6)
                {
                    flpDone.Controls.Add(lbl);
                }
            }
        }
        private Label CreateLabel(string text, int taskId)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Tag = taskId;
            lbl.Text = text;
            lbl.BackColor = Color.GreenYellow;
            lbl.Size = new Size(100, 100);
            lbl.MouseDown += lbl_MouseDown;
            return lbl;
        }

        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            _draggingLabel = sender as Label;
            DoDragDrop(_draggingLabel, DragDropEffects.Copy);
        }

        private void lblInsert_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void lblInsert_DragDrop(object sender, DragEventArgs e)
        {
            if (_draggingLabel != null)
            {

                FlowLayoutPanel flp = sender as FlowLayoutPanel;
                TaskLogBusiness tlBuss = new TaskLogBusiness();
                Entity.TaskLog taskLog = new Entity.TaskLog();
                //e.Effect = DragDropEffects.Copy;
                taskLog.TaskID = (int)_draggingLabel.Tag;
                taskLog.TaskDate = DateTime.Now;

                int flpId = int.Parse(flp.Tag.ToString()) ;

                if (flpId== 1)
                {
                    taskLog.TaskStatusID = 2;
                }
                else if (flpId== 2 && _user.RoleID == 5)
                {
                    taskLog.TaskStatusID = 3;
                }
                else if (flpId== 2 && _user.RoleID == 4)
                {
                    taskLog.TaskStatusID = 5;
                }
                else if (flpId == 3 && _user.RoleID == 5)
                {
                    taskLog.TaskStatusID = 4;
                }
                else if (flpId == 3 && _user.RoleID == 4)
                {
                    taskLog.TaskStatusID = 6;
                }
                
                bool result = false;
             
                try
                {
                    result = tlBuss.Add(taskLog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                if (result == true)
                {
                    ((FlowLayoutPanel)(_draggingLabel.Parent)).Controls.Remove(_draggingLabel);
                    flp.Controls.Add(_draggingLabel);
                }
                _draggingLabel = null;
            }
        }
    }
}
