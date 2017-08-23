namespace TaskManagmentMainForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msManager = new System.Windows.Forms.MenuStrip();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectEditM = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectListM = new System.Windows.Forms.ToolStripMenuItem();
            this.mi = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployeeEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCustomerEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlHi = new System.Windows.Forms.Panel();
            this.lblHi = new System.Windows.Forms.Label();
            this.msLeaderAnalist = new System.Windows.Forms.MenuStrip();
            this.projeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectListLA = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployeeListLA = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miCustomerListLA = new System.Windows.Forms.ToolStripMenuItem();
            this.msDevTest = new System.Windows.Forms.MenuStrip();
            this.görevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msManager.SuspendLayout();
            this.pnlLogIn.SuspendLayout();
            this.pnlHi.SuspendLayout();
            this.msLeaderAnalist.SuspendLayout();
            this.msDevTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // msManager
            // 
            this.msManager.Dock = System.Windows.Forms.DockStyle.Right;
            this.msManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeToolStripMenuItem,
            this.mi,
            this.müşteriToolStripMenuItem});
            this.msManager.Location = new System.Drawing.Point(500, 631);
            this.msManager.Name = "msManager";
            this.msManager.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msManager.Size = new System.Drawing.Size(96, 0);
            this.msManager.TabIndex = 1;
            this.msManager.Text = "menuStrip1";
            this.msManager.Visible = false;
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProjectEditM,
            this.miProjectListM});
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.projeToolStripMenuItem.Text = "Proje";
            // 
            // miProjectEditM
            // 
            this.miProjectEditM.Name = "miProjectEditM";
            this.miProjectEditM.Size = new System.Drawing.Size(136, 22);
            this.miProjectEditM.Text = "Proje Ekle";
            this.miProjectEditM.Click += new System.EventHandler(this.miProjectEdit_Click);
            // 
            // miProjectListM
            // 
            this.miProjectListM.Name = "miProjectListM";
            this.miProjectListM.Size = new System.Drawing.Size(136, 22);
            this.miProjectListM.Text = "Proje Listesi";
            this.miProjectListM.Click += new System.EventHandler(this.miProjectList_Click);
            // 
            // mi
            // 
            this.mi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployeeEdit,
            this.miEmployeeList});
            this.mi.Name = "mi";
            this.mi.Size = new System.Drawing.Size(59, 19);
            this.mi.Text = "Personel";
            // 
            // miEmployeeEdit
            // 
            this.miEmployeeEdit.Name = "miEmployeeEdit";
            this.miEmployeeEdit.Size = new System.Drawing.Size(154, 22);
            this.miEmployeeEdit.Text = "Personel Ekle";
            this.miEmployeeEdit.Click += new System.EventHandler(this.miEmployeeEdit_Click);
            // 
            // miEmployeeList
            // 
            this.miEmployeeList.Name = "miEmployeeList";
            this.miEmployeeList.Size = new System.Drawing.Size(154, 22);
            this.miEmployeeList.Text = "Personel Listesi";
            this.miEmployeeList.Click += new System.EventHandler(this.miEmployeeList_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCustomerEdit,
            this.miCustomerList});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // miCustomerEdit
            // 
            this.miCustomerEdit.Name = "miCustomerEdit";
            this.miCustomerEdit.Size = new System.Drawing.Size(149, 22);
            this.miCustomerEdit.Text = "Müşteri Ekle";
            this.miCustomerEdit.Click += new System.EventHandler(this.miCustomerEdit_Click);
            // 
            // miCustomerList
            // 
            this.miCustomerList.Name = "miCustomerList";
            this.miCustomerList.Size = new System.Drawing.Size(149, 22);
            this.miCustomerList.Text = "Müşteri Listesi";
            this.miCustomerList.Click += new System.EventHandler(this.miCustomerList_Click);
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogIn.BackgroundImage")));
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.lblPassword);
            this.pnlLogIn.Controls.Add(this.lblMail);
            this.pnlLogIn.Controls.Add(this.txtPassword);
            this.pnlLogIn.Controls.Add(this.txtMail);
            this.pnlLogIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogIn.Location = new System.Drawing.Point(0, 51);
            this.pnlLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(757, 580);
            this.pnlLogIn.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(258, 30);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(71, 24);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Giriş";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 73);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Şifre:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(30, 36);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 71);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(100, 33);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(133, 20);
            this.txtMail.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogOut.Location = new System.Drawing.Point(340, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(71, 24);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Çıkış";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlHi
            // 
            this.pnlHi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlHi.Controls.Add(this.lblHi);
            this.pnlHi.Controls.Add(this.btnLogOut);
            this.pnlHi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHi.Location = new System.Drawing.Point(0, 0);
            this.pnlHi.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHi.Name = "pnlHi";
            this.pnlHi.Size = new System.Drawing.Size(757, 51);
            this.pnlHi.TabIndex = 3;
            this.pnlHi.Visible = false;
            // 
            // lblHi
            // 
            this.lblHi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHi.Location = new System.Drawing.Point(11, 4);
            this.lblHi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(267, 45);
            this.lblHi.TabIndex = 6;
            this.lblHi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHi.UseCompatibleTextRendering = true;
            // 
            // msLeaderAnalist
            // 
            this.msLeaderAnalist.Dock = System.Windows.Forms.DockStyle.Right;
            this.msLeaderAnalist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msLeaderAnalist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeToolStripMenuItem1,
            this.personelToolStripMenuItem,
            this.müşteriToolStripMenuItem1});
            this.msLeaderAnalist.Location = new System.Drawing.Point(594, 631);
            this.msLeaderAnalist.Name = "msLeaderAnalist";
            this.msLeaderAnalist.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msLeaderAnalist.Size = new System.Drawing.Size(96, 0);
            this.msLeaderAnalist.TabIndex = 5;
            this.msLeaderAnalist.Text = "menuStrip1";
            this.msLeaderAnalist.Visible = false;
            // 
            // projeToolStripMenuItem1
            // 
            this.projeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProjectListLA});
            this.projeToolStripMenuItem1.Name = "projeToolStripMenuItem1";
            this.projeToolStripMenuItem1.Size = new System.Drawing.Size(59, 19);
            this.projeToolStripMenuItem1.Text = "Proje";
            // 
            // miProjectListLA
            // 
            this.miProjectListLA.Name = "miProjectListLA";
            this.miProjectListLA.Size = new System.Drawing.Size(136, 22);
            this.miProjectListLA.Text = "Proje Listesi";
            this.miProjectListLA.Click += new System.EventHandler(this.miProjectList_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployeeListLA});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // miEmployeeListLA
            // 
            this.miEmployeeListLA.Name = "miEmployeeListLA";
            this.miEmployeeListLA.Size = new System.Drawing.Size(154, 22);
            this.miEmployeeListLA.Text = "Personel Listesi";
            this.miEmployeeListLA.Click += new System.EventHandler(this.miEmployeeList_Click);
            // 
            // müşteriToolStripMenuItem1
            // 
            this.müşteriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCustomerListLA});
            this.müşteriToolStripMenuItem1.Name = "müşteriToolStripMenuItem1";
            this.müşteriToolStripMenuItem1.Size = new System.Drawing.Size(59, 19);
            this.müşteriToolStripMenuItem1.Text = "Müşteri";
            // 
            // miCustomerListLA
            // 
            this.miCustomerListLA.Name = "miCustomerListLA";
            this.miCustomerListLA.Size = new System.Drawing.Size(149, 22);
            this.miCustomerListLA.Text = "Müşteri Listesi";
            this.miCustomerListLA.Click += new System.EventHandler(this.miCustomerList_Click);
            // 
            // msDevTest
            // 
            this.msDevTest.BackColor = System.Drawing.SystemColors.GrayText;
            this.msDevTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.msDevTest.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msDevTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görevToolStripMenuItem});
            this.msDevTest.Location = new System.Drawing.Point(594, 51);
            this.msDevTest.Name = "msDevTest";
            this.msDevTest.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msDevTest.Size = new System.Drawing.Size(96, 370);
            this.msDevTest.TabIndex = 7;
            this.msDevTest.Text = "menuStrip1";
            this.msDevTest.Visible = false;
            // 
            // görevToolStripMenuItem
            // 
            this.görevToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görevListesiToolStripMenuItem,
            this.görevlerimToolStripMenuItem});
            this.görevToolStripMenuItem.Name = "görevToolStripMenuItem";
            this.görevToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.görevToolStripMenuItem.Text = "Görev";
            // 
            // görevListesiToolStripMenuItem
            // 
            this.görevListesiToolStripMenuItem.Name = "görevListesiToolStripMenuItem";
            this.görevListesiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.görevListesiToolStripMenuItem.Text = "Görev Listesi";
            this.görevListesiToolStripMenuItem.Click += new System.EventHandler(this.miTaskList_Click);
            // 
            // görevlerimToolStripMenuItem
            // 
            this.görevlerimToolStripMenuItem.Name = "görevlerimToolStripMenuItem";
            this.görevlerimToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.görevlerimToolStripMenuItem.Text = "Görevlerim";
            this.görevlerimToolStripMenuItem.Click += new System.EventHandler(this.miMyTasks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 382);
            this.Controls.Add(this.msLeaderAnalist);
            this.Controls.Add(this.msManager);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.msDevTest);
            this.Controls.Add(this.pnlHi);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msManager;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.msManager.ResumeLayout(false);
            this.msManager.PerformLayout();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.pnlHi.ResumeLayout(false);
            this.msLeaderAnalist.ResumeLayout(false);
            this.msLeaderAnalist.PerformLayout();
            this.msDevTest.ResumeLayout(false);
            this.msDevTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msManager;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel pnlHi;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miProjectEditM;
        private System.Windows.Forms.ToolStripMenuItem miProjectListM;
        private System.Windows.Forms.ToolStripMenuItem mi;
        private System.Windows.Forms.ToolStripMenuItem miEmployeeEdit;
        private System.Windows.Forms.ToolStripMenuItem miEmployeeList;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCustomerEdit;
        private System.Windows.Forms.ToolStripMenuItem miCustomerList;
        private System.Windows.Forms.MenuStrip msLeaderAnalist;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miProjectListLA;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEmployeeListLA;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miCustomerListLA;
        private System.Windows.Forms.MenuStrip msDevTest;
        private System.Windows.Forms.ToolStripMenuItem görevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevlerimToolStripMenuItem;
        private System.Windows.Forms.Label lblHi;
    }
}