namespace SteamAccountManager
{
    partial class AccountMngr
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
            this.btnConfigPath = new System.Windows.Forms.Button();
            this.txtConfigPath = new System.Windows.Forms.TextBox();
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desciption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config Path";
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(12, 55);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(326, 23);
            this.btnConfigPath.TabIndex = 1;
            this.btnConfigPath.Text = "Load Config Path";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            this.btnConfigPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConfigPath
            // 
            this.txtConfigPath.AllowDrop = true;
            this.txtConfigPath.Location = new System.Drawing.Point(12, 29);
            this.txtConfigPath.Name = "txtConfigPath";
            this.txtConfigPath.Size = new System.Drawing.Size(326, 20);
            this.txtConfigPath.TabIndex = 2;
            this.txtConfigPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtConfigPath_DragDrop);
            this.txtConfigPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtConfigPath_DragEnter);
            // 
            // lvAccounts
            // 
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Password,
            this.Desciption});
            this.lvAccounts.Location = new System.Drawing.Point(12, 84);
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(326, 166);
            this.lvAccounts.TabIndex = 3;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            this.lvAccounts.DoubleClick += new System.EventHandler(this.lvAccounts_DoubleClick);
            this.lvAccounts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAccounts_MouseClick);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 88;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 65;
            // 
            // Desciption
            // 
            this.Desciption.Text = "Desciption";
            this.Desciption.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // AccountMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 262);
            this.Controls.Add(this.lvAccounts);
            this.Controls.Add(this.txtConfigPath);
            this.Controls.Add(this.btnConfigPath);
            this.Controls.Add(this.label1);
            this.Name = "AccountMngr";
            this.Text = "Steam Account Manager";
            this.Load += new System.EventHandler(this.AccountMngr_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigPath;
        private System.Windows.Forms.TextBox txtConfigPath;
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Desciption;
    }
}

