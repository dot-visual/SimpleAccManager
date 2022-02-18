using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SteamAccountManager
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
            btnSave.DialogResult = DialogResult.OK;
        }

        public ListViewItem getAccount()
        {
            ListViewItem lvi = new ListViewItem(new string[] { txtUsername.Text, "*********", txtDescription.Text });
            lvi.Tag = txtPassword.Text;
            return lvi;
        }
    }
}
