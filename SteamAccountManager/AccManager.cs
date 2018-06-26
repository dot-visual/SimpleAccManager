using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace SteamAccountManager
{
    public partial class AccountMngr : Form
    {
        public AccountMngr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["ConfigPath"] = txtConfigPath.Text;
            Properties.Settings.Default.Save();
            LoadAccs();
        }

        private void AccountMngr_Load(object sender, EventArgs e)
        {
            try
            {
                String configPath = Properties.Settings.Default["ConfigPath"].ToString();

                if (configPath != String.Empty)
                {
                    txtConfigPath.Text = configPath;
                    LoadAccs();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Input Config path first!");
            }

        }

        private void lvAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvAccounts.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logIntoAcc();
        }

        private void logIntoAcc()
        {
            string username = lvAccounts.SelectedItems[0].SubItems[0].Text;
            var password = lvAccounts.SelectedItems[0].Tag;
            foreach (var process in Process.GetProcessesByName("Steam"))
            {
                process.Kill();
            }
            Process.Start("C:\\Program Files (x86)\\Steam\\Steam.exe", " -login " + username + " " + password);
        }

        private void lvAccounts_DoubleClick(object sender, EventArgs e)
        {
            logIntoAcc();
        }

        private void txtConfigPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtConfigPath.Text = files[0];
            }
        }

        private void txtConfigPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private Boolean LoadAccs()
        {
            try
            {
                string path = txtConfigPath.Text;

                if (File.Exists(path))
                {
                    XmlTextReader xmlReader = new XmlTextReader(path);
                    string username = string.Empty;
                    string password = string.Empty;
                    string notes = string.Empty;

                    while (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name.Equals("Account"))
                        {

                            username = xmlReader.GetAttribute("username");
                            password = xmlReader.GetAttribute("password");
                            notes = xmlReader.GetAttribute("notes");
                            string[] row = { username, "*********", notes };
                            if (!username.Equals(""))
                            {
                                ListViewItem lvi = new ListViewItem(row);
                                lvi.Tag = password;
                                lvAccounts.Items.Add(lvi);
                            }

                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
