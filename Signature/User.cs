using System;
using System.Windows.Forms;

namespace Signature
{
    public partial class User : Form
    {
        private string username;
        public User(string username)
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

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            var changePass = new ChangePass(username);
            Hide();
            changePass.ShowDialog();
            Show();
        }
    }
}
