using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание
{
    public partial class Form1 : Form
    {
        private string userRole;
        private int currentUserId;
        private string currentUserName;
        private int currentCarIndex = 0;
        private DataTable carTable;
        private bool isSingleView = false;

        private string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=CarAppDB;Integrated Security=True;TrustServerCertificate=True";

        public Form1(string role, int userId, string username = "")
        {
            InitializeComponent();

            userRole = role;
            currentUserId = userId;
            currentUserName = username;

            if (!string.IsNullOrEmpty(currentUserName))
            {
                label_hello.Text = "Здравей, " + currentUserName + "!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadBrands();

            if (userRole == "user")
            {
                Add.Visible = false;
                edit.Visible = false;
                Delete.Visible = false;
                Delete_all.Visible = false;
                View.Visible = true;
                View_all.Visible = true;
                Filter.Visible = true;
                button_makeAdmin.Visible = false;
                button_removeAdmin.Visible = false;
                dataGridViewUsers.Visible = false;
                button_deleteUser.Visible = false;
                imageTextBox.Visible = false;
                button1.Visible = false;
                label_users.Visible = false;
            }
            else if (userRole == "admin")
            {
                Add.Visible = true;
                edit.Visible = true;
                Delete.Visible = true;
                Delete_all.Visible = true;
                View.Visible = true;
                View_all.Visible = true;
                Filter.Visible = true;

                LoadUsers();
            }
        }
        private void LoadCars(string brandFilter = "", decimal? minPrice = null, decimal? maxPrice = null)
        {
            string query = "SELECT Id, Brand, Model, Year, Price, Image FROM Cars WHERE 1=1";

            if (!string.IsNullOrEmpty(brandFilter))
                query += " AND Brand = @brand";

            if (minPrice.HasValue)
                query += " AND Price >= @minPrice";

            if (maxPrice.HasValue)
                query += " AND Price <= @maxPrice";

            query += " ORDER BY Id ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                if (!string.IsNullOrEmpty(brandFilter))
                    cmd.Parameters.AddWithValue("@brand", brandFilter);

                if (minPrice.HasValue)
                    cmd.Parameters.AddWithValue("@minPrice", minPrice.Value);

                if (maxPrice.HasValue)
                    cmd.Parameters.AddWithValue("@maxPrice", maxPrice.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                carTable = new DataTable();
                adapter.Fill(carTable);
            }

            if (carTable.Rows.Count > 0)
            {
                currentCarIndex = 0;
                DisplayCar(currentCarIndex);
            }
        }

        private void LoadBrands()
        {
            string query = "SELECT DISTINCT Brand FROM Cars ORDER BY Brand";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxBrand.Items.Clear();
                    comboBoxBrand.Items.Add(""); 

                    while (reader.Read())
                    {
                        comboBoxBrand.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void DisplayCar(int index)
        {
            if (carTable == null || index < 0 || index >= carTable.Rows.Count)
                return;

            DataRow row = carTable.Rows[index];

            idTextBox.Text = row["Id"].ToString();
            brandTextBox.Text = row["Brand"].ToString();
            modelTextBox.Text = row["Model"].ToString();
            yearTextBox.Text = row["Year"].ToString();     
            priceTextBox.Text = row["Price"].ToString();
            imageTextBox.Text = row["Image"].ToString();

            string imagePath = row["Image"].ToString();
            pictureBox1.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            if (!isSingleView && dataGridView1.DataSource != null)
            {
                dataGridView1.ClearSelection();
                if (index < dataGridView1.Rows.Count)
                    dataGridView1.Rows[index].Selected = true;
            }
        }


        private void SelectCarRow(int index)
        {
            if (dataGridView1.Rows.Count == 0 || index < 0 || index >= dataGridView1.Rows.Count)
                return;

            dataGridView1.ClearSelection();
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
        }

        private void View_all_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Cars";
            carTable = new DataTable();
            comboBoxBrand.SelectedIndex = 0; 
            textBoxMinPrice.Clear();
            textBoxMaxPrice.Clear();
            textBoxYearFrom.Clear();
            textBoxYearTo.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(carTable);
            }

            if (carTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = carTable;
                currentCarIndex = 0;
                isSingleView = false;
                DisplayCar(currentCarIndex);
            }
        }
        private void View_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text) || !int.TryParse(idTextBox.Text, out int id))
            {
                MessageBox.Show("Моля, въведете валидно ID.");
                return;
            }

            string queryAll = "SELECT * FROM Cars";

            carTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryAll, connection);
                adapter.Fill(carTable);
            }

            int foundIndex = -1;
            for (int i = 0; i < carTable.Rows.Count; i++)
            {
                if (carTable.Rows[i]["Id"].ToString() == id.ToString())
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                currentCarIndex = foundIndex;

                DataTable oneRowTable = carTable.Clone();
                oneRowTable.ImportRow(carTable.Rows[foundIndex]);

                dataGridView1.DataSource = oneRowTable;

                DisplayCar(currentCarIndex);
            }
            else
            {
                MessageBox.Show("Не е намерен запис с това ID.");
                dataGridView1.DataSource = null;
                pictureBox1.Image = null;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(brandTextBox.Text) ||
                string.IsNullOrWhiteSpace(modelTextBox.Text) ||
                string.IsNullOrWhiteSpace(yearTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета!");
                return;
            }

            if (!int.TryParse(yearTextBox.Text, out int year))
            {
                MessageBox.Show("Моля, въведете валидна година.");
                return;
            }

            if (!int.TryParse(priceTextBox.Text, out int price))
            {
                MessageBox.Show("Моля, въведете валидна цена.");
                return;
            }

            string query = @"
        INSERT INTO Cars (Brand, Model, Year, Price, Image) 
        VALUES (@brand, @model, @year, @price, @image)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@brand", brandTextBox.Text);
                    cmd.Parameters.AddWithValue("@model", modelTextBox.Text);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@image", imageTextBox.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Записът е добавен успешно!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Грешка при добавяне на записа: " + ex.Message);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idTextBox.Text, out int id))
            {
                MessageBox.Show("Невалиден идентификатор.");
                return;
            }

            if (string.IsNullOrWhiteSpace(brandTextBox.Text) ||
                string.IsNullOrWhiteSpace(modelTextBox.Text) ||
                string.IsNullOrWhiteSpace(yearTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета!");
                return;
            }

            if (!int.TryParse(yearTextBox.Text, out int year))
            {
                MessageBox.Show("Моля, въведете валидна година.");
                return;
            }

            if (!int.TryParse(priceTextBox.Text, out int price))
            {
                MessageBox.Show("Моля, въведете валидна цена.");
                return;
            }

            string query = "UPDATE Cars SET Brand=@brand, Model=@model, Year=@year, Price=@price, Image=@image WHERE Id=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@brand", brandTextBox.Text);
                cmd.Parameters.AddWithValue("@model", modelTextBox.Text);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@image", imageTextBox.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Записът е обновен успешно!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text) || !int.TryParse(idTextBox.Text, out int carId))
            {
                MessageBox.Show("Моля, въведете валидно ID.");
                return;
            }

            var confirm = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?",
                                           "Потвърждение",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string query = "DELETE FROM Cars WHERE Id=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@id", carId);
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Записът е изтрит успешно!");
                        View_all_Click(null, null); 
                    }
                    else
                    {
                        MessageBox.Show("Не е намерен запис с това ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при изтриване: " + ex.Message);
                }
            }
        }

        private void Delete_all_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете всички записи?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Cars";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Всички записи са изтрити!");
                }
            }
        }
        private void Filter_Click(object sender, EventArgs e)
        {
            string selectedBrand = comboBoxBrand.SelectedItem?.ToString();

            string minPriceText = textBoxMinPrice.Text.Trim();
            string maxPriceText = textBoxMaxPrice.Text.Trim();

            string yearFromText = textBoxYearFrom.Text.Trim();
            string yearToText = textBoxYearTo.Text.Trim();

            int minPrice = 0;
            int maxPrice = int.MaxValue;

            int yearFrom = int.MinValue;
            int yearTo = int.MaxValue;

            if (!string.IsNullOrEmpty(minPriceText))
            {
                if (!int.TryParse(minPriceText, out minPrice))
                {
                    MessageBox.Show("Моля въведете валидна минимална цена.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(maxPriceText))
            {
                if (!int.TryParse(maxPriceText, out maxPrice))
                {
                    MessageBox.Show("Моля въведете валидна максимална цена.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(yearFromText))
            {
                if (!int.TryParse(yearFromText, out yearFrom))
                {
                    MessageBox.Show("Моля въведете валидна начална година.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(yearToText))
            {
                if (!int.TryParse(yearToText, out yearTo))
                {
                    MessageBox.Show("Моля въведете валидна крайна година.");
                    return;
                }
            }
            if (minPrice > maxPrice)
            {
                MessageBox.Show("Минималната цена не може да е по-голяма от максималната.");
                return;
            }
            if (yearFrom > yearTo)
            {
                MessageBox.Show("Началната година не може да е по-голяма от крайната.");
                return;
            }

            string query = "SELECT * FROM Cars WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(selectedBrand) && selectedBrand != "Всички")
            {
                query += " AND Brand = @brand";
                parameters.Add(new SqlParameter("@brand", selectedBrand));
            }

            query += " AND Price >= @minPrice";
            parameters.Add(new SqlParameter("@minPrice", minPrice));

            query += " AND Price <= @maxPrice";
            parameters.Add(new SqlParameter("@maxPrice", maxPrice));

            query += " AND Year >= @yearFrom";
            parameters.Add(new SqlParameter("@yearFrom", yearFrom));

            query += " AND Year <= @yearTo";
            parameters.Add(new SqlParameter("@yearTo", yearTo));

            query += " ORDER BY Id ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable filteredTable = new DataTable();
                adapter.Fill(filteredTable);

                dataGridView1.DataSource = filteredTable;

                if (filteredTable.Rows.Count > 0)
                {
                    currentCarIndex = 0;
                    DisplayCar(currentCarIndex);
                }
                else
                {
                    MessageBox.Show("Няма намерени коли с тези критерии.");
                }
            }
        }

        private void button_addToFavorites_Click(object sender, EventArgs e)
        {
            int userId = currentUserId;
            int carId = Convert.ToInt32(idTextBox.Text);

            string query = "INSERT INTO Favorite_Cars (UserId, CarId) VALUES (@userId, @carId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@carId", carId);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Кола добавена в любими!");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Тази кола вече е в любимите!");
                    else
                        MessageBox.Show("Грешка: " + ex.Message);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Изберете изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageTextBox.Text = openFileDialog.FileName;
                }
            }
        }
        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Username, Email, Phone, Is_Admin FROM Login_information";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewUsers.DataSource = table;

                if (dataGridViewUsers.Columns.Contains("Is_Admin"))
                {
                    dataGridViewUsers.Columns["Is_Admin"].Visible = false;
                }
            }
        }
        private void button_deleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете този потребител?", "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteUser(selectedId);
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете потребител за изтриване.");
            }
        }

        private void DeleteUser(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Login_information WHERE Id = @Id AND Is_Admin = 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        private void button_makeAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете потребител от списъка.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
            bool isAlreadyAdmin = Convert.ToBoolean(dataGridViewUsers.SelectedRows[0].Cells["Is_Admin"].Value);

            if (isAlreadyAdmin)
            {
                MessageBox.Show("Потребителят вече е администратор.");
                return;
            }

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да направите този потребител администратор?",
                                                  "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE Login_information SET Is_Admin = 1 WHERE Id = @userId";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Потребителят беше успешно направен администратор.");
                LoadUsers();
            }
        }
        private void button_removeAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете потребител от списъка.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
            bool isAdmin = Convert.ToBoolean(dataGridViewUsers.SelectedRows[0].Cells["Is_Admin"].Value);

            if (!isAdmin)
            {
                MessageBox.Show("Този потребител не е администратор.");
                return;
            }

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да премахнете администраторските права на този потребител?",
                                                  "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE Login_information SET Is_Admin = 0 WHERE Id = @userId";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Администраторските права бяха премахнати успешно.");
                LoadUsers();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
        private void button_myProfile_Click(object sender, EventArgs e)
        {
            myProfile profileForm = new myProfile(currentUserId);
            profileForm.ShowDialog();
        }
        private void button_Previous_Click(object sender, EventArgs e)
        {
            if (carTable != null && currentCarIndex > 0)
            {
                currentCarIndex--;
                DisplayCar(currentCarIndex);
            }
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (carTable != null && currentCarIndex < carTable.Rows.Count - 1)
            {
                currentCarIndex++;
                DisplayCar(currentCarIndex);
            }
        }
        private void button_myFavorites_Click(object sender, EventArgs e)
        {
            Favorite_Cars favoritesForm = new Favorite_Cars(currentUserId);
            favoritesForm.Show();
        }
        private void brandLabel(object sender, EventArgs e) { }
        private void brandTextBox_TextChanged(object sender, EventArgs e) { }
        private void modelLabel_Click(object sender, EventArgs e) { }
        private void modelTextBox_TextChanged(object sender, EventArgs e) { }
        private void priceLabel_Click(object sender, EventArgs e) { }
        private void priceTextBox_TextChanged(object sender, EventArgs e) { }
        private void imageLabel_Click(object sender, EventArgs e) { }
        private void imageTextBox_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void idTextBox_TextChanged(object sender, EventArgs e) { }
        private void idLabel_Click(object sender, EventArgs e) { }
        private void label_hello_Click(object sender, EventArgs e) { }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e) { }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) { }
        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e) { }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label_Price_Click(object sender, EventArgs e) { }
    }
}
