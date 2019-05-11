using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Signature
{
    public partial class Sign : Form
    {
        private string username;
        public Sign(string username)
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            this.username = username;
        }
        Graphics g;
        List<Point> points = new List<Point>();
        Pen pen = new Pen(Color.Black, 2);
        bool paint = false;
        Point pBeg;
        Point pEnd;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Invalidate();
            points.Clear();
            paint = true;
            pBeg = e.Location;
        }
        private void DBSignUpdate(SqlConnection conn, string sign, string user)
        {
            var command = new SqlCommand(
                    @"UPDATE [Users]
                        SET [Signature] = @sign
                        WHERE ([Username] = @user)", conn);
            command.Parameters.AddWithValue("@sign", sign);
            command.Parameters.AddWithValue("@user", user);
            command.ExecuteNonQuery();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            string currentDirections = DataHandler.Directions(points);
            string connectionString = "Data Source=ANDREY;Initial Catalog=Signatures;Integrated Security=True";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                var command = new SqlCommand(
                    @"SELECT [Signature]
                        FROM [Users]
                        WHERE ([Username] = @user)", conn);
                command.Parameters.AddWithValue("@user", username);
                var reader = command.ExecuteReader();
                string previousDirections = "";
                if (reader.Read())
                {
                    if (reader.IsDBNull(0)) //Если подписи нет, записываем в БД
                    {
                        reader.Close();
                        DBSignUpdate(conn, currentDirections, username);
                    }
                    else //Если подпись есть, сравниваем подписи 
                    {
                        previousDirections = reader.GetString(0).Trim(' ');
                        reader.Close();
                        double match = DataHandler.LevensteinMatch(currentDirections, previousDirections);
                        if (match > 60) //70 было бы лучше если честно
                        {
                            DBSignUpdate(conn, currentDirections, username);
                        }
                        else
                        {
                            MessageBox.Show("Подпись не распознана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
            Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                pEnd = e.Location;
                g.DrawLine(pen, pBeg, pEnd);
                pBeg = pEnd;
                points.Add(pEnd);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
