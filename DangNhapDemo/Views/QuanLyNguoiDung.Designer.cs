namespace DangNhapDemo
{
    partial class QuanLyNguoiDung
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuSignUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.clhdUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdCreate_at = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSignUp,
            this.menuLogout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuSignUp
            // 
            this.menuSignUp.Name = "menuSignUp";
            this.menuSignUp.Size = new System.Drawing.Size(60, 20);
            this.menuSignUp.Text = "Sign Up";
            this.menuSignUp.Click += new System.EventHandler(this.menuSignUp_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(57, 20);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(784, 537);
            this.panel1.TabIndex = 2;
            // 
            // lvUsers
            // 
            this.lvUsers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhdUsername,
            this.clhdPassword,
            this.clhdCreate_at});
            this.lvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsers.GridLines = true;
            this.lvUsers.Location = new System.Drawing.Point(0, 10);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(784, 527);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // clhdUsername
            // 
            this.clhdUsername.Text = "Username";
            this.clhdUsername.Width = 222;
            // 
            // clhdPassword
            // 
            this.clhdPassword.Text = "Password";
            this.clhdPassword.Width = 268;
            // 
            // clhdCreate_at
            // 
            this.clhdCreate_at.Text = "Create At";
            this.clhdCreate_at.Width = 276;
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "QuanLyNguoiDung";
            this.Text = "QuanLyNguoiDung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyNguoiDung_FormClosed);
            this.SizeChanged += new System.EventHandler(this.QuanLyNguoiDung_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.QuanLyNguoiDung_VisibleChanged);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuSignUp;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader clhdUsername;
        private System.Windows.Forms.ColumnHeader clhdPassword;
        private System.Windows.Forms.ColumnHeader clhdCreate_at;
    }
}