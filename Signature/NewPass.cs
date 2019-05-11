using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Signature
{
    public partial class NewPass : Form
    {
        private string username;
        public NewPass(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string pass1 = textBoxPassword1.Text;
            string pass2 = textBoxPassword2.Text;
            if (!string.IsNullOrEmpty(pass1) && !string.IsNullOrEmpty(pass2))
            {
                if (pass1.Equals(pass2))
                {
                    string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(
                            @"UPDATE    [Users]
                                SET     [IsTemporary] = 0,
                                        [Password] = @pass
                                WHERE   ([Username] = @user)", conn);
                        command.Parameters.AddWithValue("@user", username);
                        command.Parameters.AddWithValue("@pass", DataHandler.hash(pass1));
                        command.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка: " + err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните оба поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
