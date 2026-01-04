using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание
{
    public partial class myProfile : Form
    {
        private int currentUserId;
        private string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=CarAppDB;Integrated Security=True;TrustServerCertificate=True";
        public myProfile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username, Phone FROM Login_information WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", currentUserId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox_username.Text = reader["Username"].ToString();
                    textBox_phoneNumber.Text = reader["Phone"].ToString();
                }
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 8) return false;

            bool hasLower = false, hasUpper = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLower(c)) hasLower = true;
                else if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsDigit(c)) hasDigit = true;
            }

            return hasLower && hasUpper && hasDigit;
        }

        private string HashPassword(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.Unicode.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }

        private string GetPasswordHashFromDatabase(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Login_information WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", userId);

                object result = cmd.ExecuteScalar();
                return result?.ToString();
            }
        }

        private bool CheckOldPassword(int userId, string inputPassword)
        {
            string inputPasswordHash = HashPassword(inputPassword);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login_information WHERE Id = @id AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@password", inputPasswordHash);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool UsernameExists(string username, int currentUserId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Login_information WHERE Username = @username AND Id != @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@id", currentUserId);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            string newUsername = textBox_username.Text.Trim();
            string newPhone = textBox_phoneNumber.Text.Trim();
            string newPassword = textBox_newPassword.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Моля, попълнете потребителско име и телефон!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(newPhone))
            {
                MessageBox.Show("Моля, въведете валиден телефонен номер (10-15 цифри, може с +).", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isChangingPassword = !string.IsNullOrWhiteSpace(textBox_oldPassword.Text) ||
                                      !string.IsNullOrWhiteSpace(textBox_newPassword.Text) ||
                                      !string.IsNullOrWhiteSpace(textBox_confirmNewPassword.Text);

            string oldPasswordHashFromDB = GetPasswordHashFromDatabase(currentUserId);
            string newPasswordHash = HashPassword(newPassword);

            if (isChangingPassword)
            {
                if (string.IsNullOrWhiteSpace(textBox_oldPassword.Text) ||
                    string.IsNullOrWhiteSpace(textBox_newPassword.Text) ||
                    string.IsNullOrWhiteSpace(textBox_confirmNewPassword.Text))
                {
                    MessageBox.Show("Моля, попълнете всички полета за смяна на парола!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!CheckOldPassword(currentUserId, textBox_oldPassword.Text))
                {
                    MessageBox.Show("Старата парола е грешна!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBox_newPassword.Text != textBox_confirmNewPassword.Text)
                {
                    MessageBox.Show("Новата парола и потвърждението не съвпадат!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newPasswordHash == oldPasswordHashFromDB)
                {
                    MessageBox.Show("Новата парола не може да бъде същата като старата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsPasswordValid(newPassword))
                {
                    MessageBox.Show("Паролата трябва да е поне 8 знака и да съдържа поне една главна, една малка буква и една цифра.");
                    return;
                }
            }

            if (UsernameExists(newUsername, currentUserId))
            {
                MessageBox.Show("Това потребителско име вече е заето. Моля, изберете друго.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordToSave = isChangingPassword ? newPasswordHash : oldPasswordHashFromDB;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Login_information SET Username = @username, Password = @password, Phone = @phone WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@username", newUsername);
                cmd.Parameters.AddWithValue("@password", passwordToSave);
                cmd.Parameters.AddWithValue("@phone", newPhone);
                cmd.Parameters.AddWithValue("@id", currentUserId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Профилът е успешно обновен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox_showPassword.Checked;
            textBox_oldPassword.UseSystemPasswordChar = !show;
            textBox_newPassword.UseSystemPasswordChar = !show;
            textBox_confirmNewPassword.UseSystemPasswordChar = !show;
        }
        private void label_newPassword_Click(object sender, EventArgs e) { }

        private void myProfile_Load(object sender, EventArgs e) { }

        private void label_username_Click(object sender, EventArgs e) { }
    }
}
