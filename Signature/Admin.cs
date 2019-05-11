using System;
using System.Windows.Forms;

namespace Signature
{
    public partial class Admin : Form
    {
        private string username;
        public Admin(string username)
        {
            InitializeComponent();
            this.username = username;
            labelUsername.Text += username + "!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            var listUsers = new ListUsers();
            Hide();
            listUsers.ShowDialog();
            Show();
        }
    }
}
