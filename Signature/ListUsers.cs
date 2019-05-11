using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Signature
{
    public partial class ListUsers : Form
    {
        public ListUsers()
        {
            InitializeComponent();
        }
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            var currentrow = dataGridViewUsers.CurrentRow;
            var blockedcell = currentrow.Cells["ColumnBlocked"];
            if (!(bool)blockedcell.Value)
            {
                buttonBlock.Text = "Запретить доступ";
            }
            else
            {
                buttonBlock.Text = "Разрешить доступ";
            }
        }
        private void GetData(int currentRow = 0)
        {
            dataGridViewUsers.Rows.Clear();
            string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                var command = new SqlCommand(
                    @"SELECT    [Username], [Blocked]
                      FROM      [Users]", conn);
                var reader = command.ExecuteReader();
                while (reader.Read()) //Если есть такой пользователь
                {
                    dataGridViewUsers.Rows.Add(reader["Username"], reader["Blocked"]);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            dataGridViewUsers.Rows[currentRow].Selected = true;
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            var currentrow = dataGridViewUsers.CurrentRow;
            string usercell = currentrow.Cells["ColumnUsername"].Value.ToString();
            bool blockcell = (bool)currentrow.Cells["ColumnBlocked"].Value;
            string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                var command = new SqlCommand(
                    @"UPDATE    [Users]
                      SET       [Blocked] = @block
                      WHERE     [Username] = @user", conn);
                command.Parameters.AddWithValue("@user", usercell);
                command.Parameters.AddWithValue("@block", !blockcell); //Обратное значение
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                GetData(dataGridViewUsers.Rows.IndexOf(currentrow));
            }
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            var newUser = new NewUser();
            Hide();
            newUser.ShowDialog();
            Show();
            GetData();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var currentrow = dataGridViewUsers.CurrentRow;
            string usercell = currentrow.Cells["ColumnUsername"].Value.ToString();
            string newpass = DataHandler.GenerateRandomString(8);
            string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                var command = new SqlCommand(
                    @"UPDATE    [Users]
                      SET       [Password] = @pass,
                                [IsTemporary] = 1
                      WHERE     [Username] = @user", conn);
                command.Parameters.AddWithValue("@user", usercell);
                command.Parameters.AddWithValue("@pass", DataHandler.hash(newpass)); //Обратное значение
                command.ExecuteNonQuery();
                MessageBox.Show("Новый пароль: " + newpass, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                GetData(dataGridViewUsers.Rows.IndexOf(currentrow));
            }
        }
    }
}
