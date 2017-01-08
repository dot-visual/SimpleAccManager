using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SteamAccountManager
{
    public partial class Accmanager : Form
    {
        public Accmanager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string path = "accs.xml";
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
                            if (!xmlReader.IsEmptyElement)
                            {
                                username = xmlReader.GetAttribute("username");
                                password = xmlReader.GetAttribute("password");
                                notes = xmlReader.GetAttribute("notes");
                                string[] row = { username, "*********", notes };
                                if (!username.Equals(""))
                                {
                                    ListViewItem lvi = new ListViewItem(row);
                                    lvi.Tag = password;
                                    listView1.Items.Add(lvi);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred!", "Something went wrong!");
            }

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logIntoAcc();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logIntoAcc();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            logIntoAcc();
        }

        private void logIntoAcc()
        {
            string username = listView1.SelectedItems[0].SubItems[0].Text;
            var password = listView1.SelectedItems[0].Tag;
            foreach (var process in Process.GetProcessesByName("Steam"))
            {
                process.Kill();
            }
            Process.Start("C:\\Program Files (x86)\\Steam\\Steam.exe", " -login " + username + " " + password);
        }
    }
}