using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Signature
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void buttonGenPass_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = DataHandler.GenerateRandomString(8);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(
                        @"INSERT INTO [Users] ([Username], [Password], [IsTemporary], [Blocked])
                          VALUES (@user, @pass, 1, 0)", conn);
                    command.Parameters.AddWithValue("@user", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@pass", DataHandler.hash(textBoxPassword.Text));
                    command.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка: " + err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    conn.Close();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
