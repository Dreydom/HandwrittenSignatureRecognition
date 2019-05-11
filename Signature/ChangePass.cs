using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Signature
{
    public partial class ChangePass : Form
    {
        private string username;
        public ChangePass(string username)
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
            string oldpass = textBoxOldPassword.Text;
            string pass1 = textBoxNewPassword1.Text;
            string pass2 = textBoxNewPassword2.Text;
            if (!string.IsNullOrEmpty(pass1) && !string.IsNullOrEmpty(pass2) && !string.IsNullOrEmpty(oldpass))
            {
                if (pass1.Equals(pass2))
                {
                    string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(
                            @"SELECT    COUNT(*)
                                FROM    [Users]
                                WHERE   [Username] = @user AND 
                                        [Password] = @pass", conn);
                        command.Parameters.AddWithValue("@user", username);
                        command.Parameters.AddWithValue("@pass", DataHandler.hash(oldpass));
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            command = new SqlCommand(
                            @"UPDATE    [Users]
                                SET     [IsTemporary] = 0,
                                        [Password] = @pass
                                WHERE   [Username] = @user", conn);
                            command.Parameters.AddWithValue("@user", username);
                            command.Parameters.AddWithValue("@pass", DataHandler.hash(pass1));
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка: " + err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        MessageBox.Show("Пароль изменен", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
