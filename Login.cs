using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Задание
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=CarAppDB;Integrated Security=True;TrustServerCertificate=True";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {}

        private void Register_button_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !checkBox_showPassword.Checked;
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Моля, въведете всички полета", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = ComputeSha256Hash(password);
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Login_information WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["Id"]);
                            bool isAdmin = Convert.ToBoolean(reader["Is_Admin"]);

                            if (isAdmin)
                            {
                                MessageBox.Show("Успешно влизане като администратор!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 adminForm = new Form1("admin", userId, username);
                                adminForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Успешно влизане като потребител!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 userForm = new Form1("user", userId, username);
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

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.Unicode.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
