using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Задание
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=CarAppDB;Integrated Security=True;TrustServerCertificate=True";
        public RegistrationForm()
        {
            InitializeComponent();
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

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasLower = false, hasUpper = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLower(c)) hasLower = true;
                else if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsDigit(c)) hasDigit = true;
            }

            return hasLower && hasUpper && hasDigit;
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();
            string phone = textBoxPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Моля, въведете имейл адрес.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Моля, въведете валиден имейл адрес.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Моля, попълнете всички полета.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Моля, въведете валиден телефонен номер (10-15 цифри, може с +).", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Паролите не съвпадат.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Паролата трябва да е поне 8 знака и да съдържа поне една главна, една малка буква и една цифра.");
                return;
            }

            string hashedPassword = ComputeSha256Hash(password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkEmailQuery = "SELECT COUNT(*) FROM Login_information WHERE Email = @Email";
                    using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkEmailCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Имейлът вече е регистриран.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string checkUsernameQuery = "SELECT COUNT(*) FROM Login_information WHERE Username = @Username";
                    using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, connection))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkUsernameCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Потребителското име вече е заето.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Login_information (Username, Password, Is_Admin, Email, Phone) VALUES (@Username, @Password, 0, @Email, @Phone)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Успешна регистрация! Моля, влезте в системата.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при регистрация: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBox_showPassword.Checked;
            if (textBoxConfirmPassword != null)
                textBoxConfirmPassword.UseSystemPasswordChar = !checkBox_showPassword.Checked;
        }

        private void button_BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegistrationForm_Load(object sender, EventArgs e) { }

        private void label_confirmPassword_Click(object sender, EventArgs e) { }
    }
}
