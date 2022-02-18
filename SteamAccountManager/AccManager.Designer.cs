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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountMngr));
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desciption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMSAccounts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddAccountItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.txtConfigPath = new System.Windows.Forms.TextBox();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.btnOpenSteamPath = new System.Windows.Forms.Button();
            this.lblSteamPath = new System.Windows.Forms.Label();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.cMSAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAccounts
            // 
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Password,
            this.Desciption});
            this.lvAccounts.HideSelection = false;
            this.lvAccounts.Location = new System.Drawing.Point(12, 121);
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(327, 221);
            this.lvAccounts.TabIndex = 3;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            this.lvAccounts.DoubleClick += new System.EventHandler(this.lvAccounts_DoubleClick);
            this.lvAccounts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAccounts_MouseClick);
            this.lvAccounts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvAccounts_MouseDown);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 88;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 84;
            // 
            // Desciption
            // 
            this.Desciption.Text = "Desciption";
            this.Desciption.Width = 150;
            // 
            // cMSAccounts
            // 
            this.cMSAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccountItem,
            this.DeleteItem});
            this.cMSAccounts.Name = "contextMenuStrip1";
            this.cMSAccounts.Size = new System.Drawing.Size(145, 48);
            // 
            // AddAccountItem
            // 
            this.AddAccountItem.Name = "AddAccountItem";
            this.AddAccountItem.Size = new System.Drawing.Size(144, 22);
            this.AddAccountItem.Text = "Add Account";
            this.AddAccountItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(144, 22);
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowDrop = true;
            this.txtPassword.Location = new System.Drawing.Point(95, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(244, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(327, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Config Path:";
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Enabled = false;
            this.btnLoadConfig.Location = new System.Drawing.Point(12, 92);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(327, 23);
            this.btnLoadConfig.TabIndex = 7;
            this.btnLoadConfig.Text = "Load Config";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnConfigPath_Click);
            // 
            // txtConfigPath
            // 
            this.txtConfigPath.AllowDrop = true;
            this.txtConfigPath.Location = new System.Drawing.Point(95, 12);
            this.txtConfigPath.Name = "txtConfigPath";
            this.txtConfigPath.Size = new System.Drawing.Size(216, 20);
            this.txtConfigPath.TabIndex = 8;
            this.txtConfigPath.TextChanged += new System.EventHandler(this.txtConfigPath_TextChanged);
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Location = new System.Drawing.Point(313, 12);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(26, 20);
            this.btnOpenConfig.TabIndex = 12;
            this.btnOpenConfig.Text = "...";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // btnOpenSteamPath
            // 
            this.btnOpenSteamPath.Location = new System.Drawing.Point(313, 38);
            this.btnOpenSteamPath.Name = "btnOpenSteamPath";
            this.btnOpenSteamPath.Size = new System.Drawing.Size(26, 20);
            this.btnOpenSteamPath.TabIndex = 18;
            this.btnOpenSteamPath.Text = "...";
            this.btnOpenSteamPath.UseVisualStyleBackColor = true;
            this.btnOpenSteamPath.Click += new System.EventHandler(this.btnOpenSteamPath_Click);
            // 
            // lblSteamPath
            // 
            this.lblSteamPath.AutoSize = true;
            this.lblSteamPath.Location = new System.Drawing.Point(13, 41);
            this.lblSteamPath.Name = "lblSteamPath";
            this.lblSteamPath.Size = new System.Drawing.Size(65, 13);
            this.lblSteamPath.TabIndex = 16;
            this.lblSteamPath.Text = "Steam Path:";
            // 
            // txtSteamPath
            // 
            this.txtSteamPath.AllowDrop = true;
            this.txtSteamPath.Location = new System.Drawing.Point(95, 38);
            this.txtSteamPath.Name = "txtSteamPath";
            this.txtSteamPath.Size = new System.Drawing.Size(216, 20);
            this.txtSteamPath.TabIndex = 17;
            // 
            // AccountMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 387);
            this.Controls.Add(this.btnOpenSteamPath);
            this.Controls.Add(this.lblSteamPath);
            this.Controls.Add(this.txtSteamPath);
            this.Controls.Add(this.btnOpenConfig);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.txtConfigPath);
            this.Controls.Add(this.lvAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountMngr";
            this.Text = "Steam Account Manager";
            this.Load += new System.EventHandler(this.AccountMngr_Load);
            this.cMSAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ContextMenuStrip cMSAccounts;
        private System.Windows.Forms.ToolStripMenuItem AddAccountItem;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Desciption;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.TextBox txtConfigPath;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.Button btnOpenSteamPath;
        private System.Windows.Forms.Label lblSteamPath;
        private System.Windows.Forms.TextBox txtSteamPath;
    }
}

