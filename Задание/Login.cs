using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Задание
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Hex string
                }
                return builder.ToString();
            }
        }
        private void button_log_in_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();

            string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=Login_Information;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Information WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            bool isAdmin = Convert.ToBoolean(reader["Is_Admin"]);

                            if (isAdmin)
                            {
                                MessageBox.Show("Успешно влизане като администратор!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 adminForm = new Form1("admin");
                                adminForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Успешно влизане като потребител!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 userForm = new Form1("user");
                                userForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Грешно потребителско име или парола.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при свързване: " + ex.Message);
                }
            }
        }


        private void Register_button_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Моля, въведете потребителско име и парола.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=Login_Information;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Проверка дали потребителското име вече съществува
                    string checkQuery = "SELECT COUNT(*) FROM Information WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Потребителското име вече съществува. Моля, изберете друго.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Ако не съществува, регистрираме новия потребител
                    string insertQuery = "INSERT INTO Information (Username, Password, Is_Admin) VALUES (@Username, @Password, 0)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Регистрацията е успешна! Можете да влезете в системата.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Регистрацията не бе успешна. Опитайте отново.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при регистрацията: " + ex.Message);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
