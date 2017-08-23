namespace TaskManagmentMainForm
{
    partial class MyTasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpAssigned = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpAssigned.SuspendLayout();
            this.flpDone.SuspendLayout();
            this.flpInProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAssigned
            // 
            this.flpAssigned.AllowDrop = true;
            this.flpAssigned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpAssigned.Controls.Add(this.label1);
            this.flpAssigned.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpAssigned.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAssigned.Location = new System.Drawing.Point(0, 0);
            this.flpAssigned.Name = "flpAssigned";
            this.flpAssigned.Size = new System.Drawing.Size(249, 497);
            this.flpAssigned.TabIndex = 2;
            this.flpAssigned.Tag = "1";
            this.flpAssigned.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblInsert_DragDrop);
            this.flpAssigned.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblInsert_DragEnter);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atanan Görevler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpDone
            // 
            this.flpDone.AllowDrop = true;
            this.flpDone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpDone.Controls.Add(this.label3);
            this.flpDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpDone.Location = new System.Drawing.Point(561, 0);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(282, 497);
            this.flpDone.TabIndex = 3;
            this.flpDone.Tag = "3";
            this.flpDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblInsert_DragDrop);
            this.flpDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblInsert_DragEnter);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Biten Görevler";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpInProgress
            // 
            this.flpInProgress.AllowDrop = true;
            this.flpInProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpInProgress.Controls.Add(this.label2);
            this.flpInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpInProgress.Location = new System.Drawing.Point(249, 0);
            this.flpInProgress.Name = "flpInProgress";
            this.flpInProgress.Size = new System.Drawing.Size(312, 497);
            this.flpInProgress.TabIndex = 4;
            this.flpInProgress.Tag = "2";
            this.flpInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblInsert_DragDrop);
            this.flpInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblInsert_DragEnter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çalışılan Görevler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 497);
            this.Controls.Add(this.flpInProgress);
            this.Controls.Add(this.flpDone);
            this.Controls.Add(this.flpAssigned);
            this.Name = "MyTasksForm";
            this.Text = "MyTasksForm";
            this.Load += new System.EventHandler(this.MyTasksForm_Load);
            this.flpAssigned.ResumeLayout(false);
            this.flpDone.ResumeLayout(false);
            this.flpInProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAssigned;
        private System.Windows.Forms.FlowLayoutPanel flpDone;
        private System.Windows.Forms.FlowLayoutPanel flpInProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}