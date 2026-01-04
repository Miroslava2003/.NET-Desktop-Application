using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Задание
{
    public partial class Favorite_Cars : Form
    {
        private int userId;
        private string connectionString = "Data Source=DESKTOP-G8UEQ33\\SQLEXPRESS;Initial Catalog=CarAppDB;Integrated Security=True;TrustServerCertificate=True";

        public Favorite_Cars(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += Favorites_Cars_Load;
            dataGridViewFavorites.SelectionChanged += dataGridViewFavorites_SelectionChanged;
        }

        private void Favorites_Cars_Load(object sender, EventArgs e)
        {
            LoadFavoriteCars();
        }

        private void LoadFavoriteCars()
        {
            string query = @"
        SELECT Cars.Id, Cars.Brand, Cars.Model, Cars.Year, Cars.Price, Cars.Image
        FROM Cars
        INNER JOIN Favorite_Cars ON Cars.Id = Favorite_Cars.CarId
        WHERE Favorite_Cars.UserId = @userId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewFavorites.DataSource = table;
 
                if (table.Rows.Count > 0)
                {
                    ShowCarDetails(0);
                }
            }
        }


        private void dataGridViewFavorites_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFavorites.CurrentRow != null)
            {
                int index = dataGridViewFavorites.CurrentRow.Index;
                ShowCarDetails(index);
            }
        }

        private void ShowCarDetails(int index)
        {
            if (index < 0 || index >= dataGridViewFavorites.Rows.Count)
                return;

            DataGridViewRow row = dataGridViewFavorites.Rows[index];

            labelBrand.Text = row.Cells["Brand"].Value?.ToString() ?? "";
            labelModel.Text = row.Cells["Model"].Value?.ToString() ?? "";
            labelPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
            labelYear.Text = row.Cells["Year"].Value?.ToString() ?? "";

            string imagePath = row.Cells["Image"].Value?.ToString() ?? "";

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                if (pictureBoxFavorite.Image != null)
                {
                    pictureBoxFavorite.Image.Dispose();
                    pictureBoxFavorite.Image = null;
                }
                pictureBoxFavorite.Image = Image.FromFile(imagePath);
                pictureBoxFavorite.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                if (pictureBoxFavorite.Image != null)
                {
                    pictureBoxFavorite.Image.Dispose();
                    pictureBoxFavorite.Image = null;
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridViewFavorites.CurrentRow == null)
            {
                MessageBox.Show("Моля, изберете кола от списъка.");
                return;
            }

            int carId = Convert.ToInt32(dataGridViewFavorites.CurrentRow.Cells["Id"].Value);

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да премахнете тази кола от любимите?",
                                                  "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Favorite_Cars WHERE UserId = @userId AND CarId = @carId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@carId", carId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Колата беше премахната от любимите.");
                LoadFavoriteCars();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelPrice_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
