using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Signature
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
            var conn = new SqlConnection(connectionString);
            try
            {
                string password = DataHandler.hash(textBoxPassword.Text);
                conn.Open();
                var command = new SqlCommand(
                    @"SELECT    [Blocked], [IsTemporary], [Signature]
                        FROM    [Users]
                        WHERE   [Username] = @user AND 
                                [Password] = @pass", conn);
                command.Parameters.AddWithValue("@user", textBoxUsername.Text);
                command.Parameters.AddWithValue("@pass", password);
                var reader = command.ExecuteReader();
                if (reader.Read()) //Если есть такой пользователь
                {
                    if (!(bool)reader["Blocked"]) //Если есть доступ
                    {
                        Hide();
                        // you may want to check if value is NULL: reader.IsDBNull(0)
                        if ((bool)reader["IsTemporary"]) //Если пароль одноразовый
                        {
                            MessageBox.Show("Необходимо сменить пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var newPass = new NewPass(textBoxUsername.Text);
                            if (newPass.ShowDialog() == DialogResult.Abort)
                            {
                                Show();
                                reader.Close();
                                return;
                            }
                        }
                        if (reader["Signature"] is DBNull) //Если подписи нет
                        {
                            MessageBox.Show("Необходимо внести подпись в базу данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        var sign = new Sign(textBoxUsername.Text);
                        if (sign.ShowDialog() == DialogResult.Abort)
                        {
                            Show();
                            reader.Close();
                            return;
                        }
                        if (textBoxUsername.Text.ToLower() == "admin") //Администратор
                        {
                            var admin = new Admin(textBoxUsername.Text);
                            if (admin.ShowDialog() == DialogResult.Abort)
                            {
                                Show();
                                reader.Close();
                                return;
                            }
                        }
                        else //Любой пользователь без прав администратора
                        {
                            var user = new User(textBoxUsername.Text);
                            if (user.ShowDialog() == DialogResult.Abort)
                            {
                                Show();
                                reader.Close();
                                return;
                            }
                        }
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Доступ запрещен администатором", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Неправильное имя пользователя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxPassword.Clear();
                conn.Close();
            }
        }

    }
}
