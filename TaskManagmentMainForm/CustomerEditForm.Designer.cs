namespace TaskManagmentMainForm
{
    partial class CustomerEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomerEmployee = new System.Windows.Forms.Button();
            this.dgvCustomerEmployee = new System.Windows.Forms.DataGridView();
            this.cmsCustomerEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiUpdateCustomerEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDeleteCustomerEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerEmployee)).BeginInit();
            this.cmsCustomerEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ülke :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şehir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adres :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCustomerID.Location = new System.Drawing.Point(84, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(211, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(83, 38);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(211, 20);
            this.txtCompanyName.TabIndex = 3;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(83, 64);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(211, 20);
            this.txtCountry.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(83, 90);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(211, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(83, 116);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(211, 54);
            this.txtAdress.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCustomer.Location = new System.Drawing.Point(21, 353);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(267, 27);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSaveCustomerEmployee
            // 
            this.btnSaveCustomerEmployee.Location = new System.Drawing.Point(156, 286);
            this.btnSaveCustomerEmployee.Name = "btnSaveCustomerEmployee";
            this.btnSaveCustomerEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnSaveCustomerEmployee.TabIndex = 5;
            this.btnSaveCustomerEmployee.Text = "Müşteri Çalışanı Ekle";
            this.btnSaveCustomerEmployee.UseVisualStyleBackColor = true;
            this.btnSaveCustomerEmployee.Click += new System.EventHandler(this.btnSaveCustomerEmployee_Click);
            // 
            // dgvCustomerEmployee
            // 
            this.dgvCustomerEmployee.AllowUserToAddRows = false;
            this.dgvCustomerEmployee.AllowUserToDeleteRows = false;
            this.dgvCustomerEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomerEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerEmployee.ContextMenuStrip = this.cmsCustomerEmployee;
            this.dgvCustomerEmployee.Location = new System.Drawing.Point(21, 189);
            this.dgvCustomerEmployee.MultiSelect = false;
            this.dgvCustomerEmployee.Name = "dgvCustomerEmployee";
            this.dgvCustomerEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerEmployee.Size = new System.Drawing.Size(273, 91);
            this.dgvCustomerEmployee.TabIndex = 6;
            this.dgvCustomerEmployee.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvCustomerEmployee_RowContextMenuStripNeeded);
            // 
            // cmsCustomerEmployee
            // 
            this.cmsCustomerEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiUpdateCustomerEmployee,
            this.cmiDeleteCustomerEmployee});
            this.cmsCustomerEmployee.Name = "cmsCustomerEmployee";
            this.cmsCustomerEmployee.Size = new System.Drawing.Size(162, 48);
            // 
            // cmiUpdateCustomerEmployee
            // 
            this.cmiUpdateCustomerEmployee.Name = "cmiUpdateCustomerEmployee";
            this.cmiUpdateCustomerEmployee.Size = new System.Drawing.Size(161, 22);
            this.cmiUpdateCustomerEmployee.Text = "Çalışan Güncelle";
            this.cmiUpdateCustomerEmployee.Click += new System.EventHandler(this.cmiUpdateCustomerEmployee_Click);
            // 
            // cmiDeleteCustomerEmployee
            // 
            this.cmiDeleteCustomerEmployee.Name = "cmiDeleteCustomerEmployee";
            this.cmiDeleteCustomerEmployee.Size = new System.Drawing.Size(161, 22);
            this.cmiDeleteCustomerEmployee.Text = "Çalışan Sil";
            this.cmiDeleteCustomerEmployee.Click += new System.EventHandler(this.cmiDeleteCustomerEmployee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Müşteri Çalışan Listesi:";
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 499);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCustomerEmployee);
            this.Controls.Add(this.btnSaveCustomerEmployee);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "CustomerEditForm";
            this.Text = "CustomerEditForm";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerEmployee)).EndInit();
            this.cmsCustomerEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSaveCustomerEmployee;
        private System.Windows.Forms.DataGridView dgvCustomerEmployee;
        private System.Windows.Forms.ContextMenuStrip cmsCustomerEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem cmiUpdateCustomerEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmiDeleteCustomerEmployee;
    }
}