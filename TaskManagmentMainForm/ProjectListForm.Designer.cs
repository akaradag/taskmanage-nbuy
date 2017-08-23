namespace TaskManagmentMainForm
{
    partial class ProjectListForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.cmsManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLeaderAnalist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projedekiGörevlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTalepleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTalebiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.cmsManager.SuspendLayout();
            this.cmsLeaderAnalist.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProject);
            this.splitContainer1.Size = new System.Drawing.Size(619, 393);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(360, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 20);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(46, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvProject
            // 
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProject.Location = new System.Drawing.Point(0, 0);
            this.dgvProject.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProject.MultiSelect = false;
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowTemplate.Height = 24;
            this.dgvProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProject.Size = new System.Drawing.Size(619, 322);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvProject_RowContextMenuStripNeeded);
            // 
            // cmsManager
            // 
            this.cmsManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.görevListesiToolStripMenuItem});
            this.cmsManager.Name = "cmsManager";
            this.cmsManager.Size = new System.Drawing.Size(171, 70);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.miEditProject_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.miDeleteProject_Click);
            // 
            // görevListesiToolStripMenuItem
            // 
            this.görevListesiToolStripMenuItem.Name = "görevListesiToolStripMenuItem";
            this.görevListesiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.görevListesiToolStripMenuItem.Text = "Projedeki Görevler";
            this.görevListesiToolStripMenuItem.Click += new System.EventHandler(this.miTaskList_Click);
            // 
            // cmsLeaderAnalist
            // 
            this.cmsLeaderAnalist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLeaderAnalist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem1,
            this.projedekiGörevlerToolStripMenuItem,
            this.müşteriTalepleriToolStripMenuItem,
            this.müşteriTalebiEkleToolStripMenuItem});
            this.cmsLeaderAnalist.Name = "cmsLeaderAnalist";
            this.cmsLeaderAnalist.Size = new System.Drawing.Size(173, 92);
            // 
            // düzenleToolStripMenuItem1
            // 
            this.düzenleToolStripMenuItem1.Name = "düzenleToolStripMenuItem1";
            this.düzenleToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.düzenleToolStripMenuItem1.Text = "Projeye Görev Ekle";
            this.düzenleToolStripMenuItem1.Click += new System.EventHandler(this.miAddTask_Click);
            // 
            // projedekiGörevlerToolStripMenuItem
            // 
            this.projedekiGörevlerToolStripMenuItem.Name = "projedekiGörevlerToolStripMenuItem";
            this.projedekiGörevlerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.projedekiGörevlerToolStripMenuItem.Text = "Projedeki Görevler";
            this.projedekiGörevlerToolStripMenuItem.Click += new System.EventHandler(this.miTaskList_Click);
            // 
            // müşteriTalepleriToolStripMenuItem
            // 
            this.müşteriTalepleriToolStripMenuItem.Name = "müşteriTalepleriToolStripMenuItem";
            this.müşteriTalepleriToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.müşteriTalepleriToolStripMenuItem.Text = "Müşteri Talepleri";
            this.müşteriTalepleriToolStripMenuItem.Click += new System.EventHandler(this.miRequestList_Click);
            // 
            // müşteriTalebiEkleToolStripMenuItem
            // 
            this.müşteriTalebiEkleToolStripMenuItem.Name = "müşteriTalebiEkleToolStripMenuItem";
            this.müşteriTalebiEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.müşteriTalebiEkleToolStripMenuItem.Text = "Müşteri Talebi Ekle";
            this.müşteriTalebiEkleToolStripMenuItem.Click += new System.EventHandler(this.miAddRequest_Click);
            // 
            // ProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 393);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectListForm";
            this.Text = "ProjectListForm";
            this.Load += new System.EventHandler(this.ProjectListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.cmsManager.ResumeLayout(false);
            this.cmsLeaderAnalist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip cmsManager;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevListesiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLeaderAnalist;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem projedekiGörevlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTalepleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTalebiEkleToolStripMenuItem;
    }
}