namespace TaskManagmentMainForm
{
    partial class CustomerListForm
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
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCustomerRefresf = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiCustomerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerListRefresh = new System.Windows.Forms.Button();
            this.txtSorch = new System.Windows.Forms.TextBox();
            this.btnFilterCompanyName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCustomerList.Location = new System.Drawing.Point(2, 124);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.Size = new System.Drawing.Size(791, 293);
            this.dgvCustomerList.TabIndex = 0;
            this.dgvCustomerList.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvCustomerList_RowContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCustomerRefresf,
            this.cmiCustomerDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 48);
            // 
            // cmsCustomerRefresf
            // 
            this.cmsCustomerRefresf.Name = "cmsCustomerRefresf";
            this.cmsCustomerRefresf.Size = new System.Drawing.Size(179, 22);
            this.cmsCustomerRefresf.Text = "Müşterileri Güncelle";
            this.cmsCustomerRefresf.Click += new System.EventHandler(this.cmsCustomerRefresf_Click);
            // 
            // cmiCustomerDelete
            // 
            this.cmiCustomerDelete.Name = "cmiCustomerDelete";
            this.cmiCustomerDelete.Size = new System.Drawing.Size(179, 22);
            this.cmiCustomerDelete.Text = "Müşterileri Sil";
            this.cmiCustomerDelete.Click += new System.EventHandler(this.cmiCustomerDelete_Click);
            // 
            // btnCustomerListRefresh
            // 
            this.btnCustomerListRefresh.Location = new System.Drawing.Point(419, 25);
            this.btnCustomerListRefresh.Name = "btnCustomerListRefresh";
            this.btnCustomerListRefresh.Size = new System.Drawing.Size(105, 23);
            this.btnCustomerListRefresh.TabIndex = 3;
            this.btnCustomerListRefresh.Text = "Yenile";
            this.btnCustomerListRefresh.UseVisualStyleBackColor = true;
            this.btnCustomerListRefresh.Click += new System.EventHandler(this.btnCustomerListRefresh_Click);
            // 
            // txtSorch
            // 
            this.txtSorch.Location = new System.Drawing.Point(219, 28);
            this.txtSorch.Name = "txtSorch";
            this.txtSorch.Size = new System.Drawing.Size(162, 20);
            this.txtSorch.TabIndex = 4;
            // 
            // btnFilterCompanyName
            // 
            this.btnFilterCompanyName.Location = new System.Drawing.Point(557, 25);
            this.btnFilterCompanyName.Name = "btnFilterCompanyName";
            this.btnFilterCompanyName.Size = new System.Drawing.Size(92, 23);
            this.btnFilterCompanyName.TabIndex = 5;
            this.btnFilterCompanyName.Text = "Ara";
            this.btnFilterCompanyName.UseVisualStyleBackColor = true;
            this.btnFilterCompanyName.Click += new System.EventHandler(this.btnFilterCompanyName_Click);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskManagmentMainForm.Properties.Resources.Customer_Services;
            this.ClientSize = new System.Drawing.Size(796, 497);
            this.Controls.Add(this.btnFilterCompanyName);
            this.Controls.Add(this.txtSorch);
            this.Controls.Add(this.btnCustomerListRefresh);
            this.Controls.Add(this.dgvCustomerList);
            this.Name = "CustomerListForm";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Button btnCustomerListRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCustomerRefresf;
        private System.Windows.Forms.ToolStripMenuItem cmiCustomerDelete;
        private System.Windows.Forms.TextBox txtSorch;
        private System.Windows.Forms.Button btnFilterCompanyName;
    }
}