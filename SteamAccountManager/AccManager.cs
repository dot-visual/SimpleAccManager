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
using System.Security.Cryptography;

namespace SteamAccountManager
{
    public partial class AccountMngr : Form
    {
        public AccountMngr()
        {
            InitializeComponent();
        }

        private void AccountMngr_Load(object sender, EventArgs e)
        {
            String configPath = Properties.Settings.Default["ConfigPath"].ToString();
            String steamPath = Properties.Settings.Default["SteamPath"].ToString();
            if (configPath != String.Empty && steamPath != String.Empty)
            {
                txtConfigPath.Text = configPath;
                txtSteamPath.Text = steamPath;
            }
        }

        private void lvAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvAccounts.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    cMSAccounts.Show(Cursor.Position);
                }
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount frmAddAccount = new AddAccount();
            if(frmAddAccount.ShowDialog(this) == DialogResult.OK)
            {
                lvAccounts.Items.Add(frmAddAccount.getAccount());
                btnSave.Enabled = true;
            }
            frmAddAccount.Close();
            frmAddAccount.Dispose();
        }

        private void lvAccounts_DoubleClick(object sender, EventArgs e)
        {
            string username = lvAccounts.SelectedItems[0].SubItems[0].Text;
            var password = lvAccounts.SelectedItems[0].Tag;
            if (txtSteamPath.Text == String.Empty)
            {
                MessageBox.Show("Please specify your Steam Path first.");
                return;
            }
           
            foreach (var process in Process.GetProcessesByName("Steam"))
            {
                process.Kill();
            }
            Process.Start(txtSteamPath.Text, " -login " + username + " " + password);
        }

        private void lvAccounts_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var focusedItem = lvAccounts.FocusedItem;
                {
                    cMSAccounts.Show(Cursor.Position);
                }
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvAccounts.Items[0].Tag.ToString());
            foreach (ListViewItem item in lvAccounts.SelectedItems)
            {
                lvAccounts.Items.Remove(item);
            }
            btnSave.Enabled = lvAccounts.Items.Count > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(txtConfigPath.Text, System.Text.Encoding.ASCII);
            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Accounts");

            foreach (ListViewItem item in lvAccounts.Items)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<Account/>");
                XmlAttribute username = doc.CreateAttribute("username");
                username.InnerText = item.SubItems[0].Text;
                XmlAttribute pw = doc.CreateAttribute("password");
                pw.InnerText = Convert.ToBase64String(AESHelper.EncryptStringToBytes(item.Tag.ToString(), txtPassword.Text));
                XmlAttribute desc = doc.CreateAttribute("description");
                desc.InnerText = item.SubItems[2].Text;
                doc.DocumentElement.Attributes.Append(username);
                doc.DocumentElement.Attributes.Append(pw);
                doc.DocumentElement.Attributes.Append(desc);
                doc.WriteContentTo(xmlWriter);
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();

            Properties.Settings.Default["ConfigPath"] = txtConfigPath.Text;
            Properties.Settings.Default["SteamPath"] = txtSteamPath.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Accounts saved Sucessfully.", "Saved");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtPassword.TextLength > 0);
            btnLoadConfig.Enabled = (txtConfigPath.TextLength > 0 && txtPassword.TextLength > 0);
        }

        private void btnConfigPath_Click(object sender, EventArgs e)
        {
            string path = txtConfigPath.Text;
            try
            {
                if (File.Exists(path))
                {
                    lvAccounts.Items.Clear();
                    StreamReader sReader = new StreamReader(path, System.Text.Encoding.ASCII);
                    XmlTextReader xmlReader = new XmlTextReader(sReader);

                    string username = string.Empty;
                    string password = string.Empty;
                    string desc = string.Empty;

                    while (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name.Equals("Account"))
                        {
                            username = xmlReader.GetAttribute("username");
                            password = xmlReader.GetAttribute("password");
                            desc = xmlReader.GetAttribute("description");
                            string[] row = { username, "*********", desc };
                            if (!username.Equals("") && !password.Equals(""))
                            {
                                ListViewItem lvi = new ListViewItem(row);
                                lvi.Tag = AESHelper.DecryptStringFromBytes(Convert.FromBase64String(password), txtPassword.Text);
                                lvAccounts.Items.Add(lvi);
                            }
                        }
                    }
                    xmlReader.Close();
                    xmlReader.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Password!","Please try again.");
            }
        }
        private void txtConfigPath_TextChanged(object sender, EventArgs e)
        {
            btnLoadConfig.Enabled = txtConfigPath.TextLength > 0 && txtPassword.TextLength > 0;
        }
        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xml Files (*.xml)|*.xml";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtConfigPath.Text = ofd.FileName;
            }
            ofd.Dispose();
        }
        private void btnOpenSteamPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Exe Files (*.exe)|*.exe";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtSteamPath.Text = ofd.FileName;
            }
            ofd.Dispose();
        }
    }
}