namespace TaskManagmentMainForm
{
    partial class RequestListForm
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
            this.txtRequestInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.cmsRequest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiUpdateRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDeleteRequest = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.cmsRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtRequestInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRequests);
            this.splitContainer1.Size = new System.Drawing.Size(648, 345);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtRequestInput
            // 
            this.txtRequestInput.Location = new System.Drawing.Point(99, 12);
            this.txtRequestInput.Name = "txtRequestInput";
            this.txtRequestInput.Size = new System.Drawing.Size(296, 20);
            this.txtRequestInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Talep Bilgisi :";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(422, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(133, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Ara";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.ContextMenuStrip = this.cmsRequest;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(0, 0);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(648, 299);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvRequests_RowContextMenuStripNeeded);
            // 
            // cmsRequest
            // 
            this.cmsRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiUpdateRequest,
            this.cmiDeleteRequest});
            this.cmsRequest.Name = "cmsRequest";
            this.cmsRequest.Size = new System.Drawing.Size(153, 70);
            // 
            // cmiUpdateRequest
            // 
            this.cmiUpdateRequest.Name = "cmiUpdateRequest";
            this.cmiUpdateRequest.Size = new System.Drawing.Size(152, 22);
            this.cmiUpdateRequest.Text = "İsteği Güncelle";
            this.cmiUpdateRequest.Click += new System.EventHandler(this.cmiUpdateRequest_Click);
            // 
            // cmiDeleteRequest
            // 
            this.cmiDeleteRequest.Name = "cmiDeleteRequest";
            this.cmiDeleteRequest.Size = new System.Drawing.Size(152, 22);
            this.cmiDeleteRequest.Text = "İsteği Sil";
            this.cmiDeleteRequest.Click += new System.EventHandler(this.cmiDeleteRequest_Click);
            // 
            // RequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 345);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RequestListForm";
            this.Text = "RequestListForm";
            this.Load += new System.EventHandler(this.RequestListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.cmsRequest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestInput;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.ContextMenuStrip cmsRequest;
        private System.Windows.Forms.ToolStripMenuItem cmiUpdateRequest;
        private System.Windows.Forms.ToolStripMenuItem cmiDeleteRequest;
    }
}