namespace Задание
{
    partial class Favorite_Cars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite_Cars));
            this.button_remove = new System.Windows.Forms.Button();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.pictureBoxFavorite = new System.Windows.Forms.PictureBox();
            this.dataGridViewFavorites = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove.Location = new System.Drawing.Point(216, 598);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(171, 58);
            this.button_remove.TabIndex = 0;
            this.button_remove.Text = "Премахни от любими";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.BackColor = System.Drawing.Color.Transparent;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.Location = new System.Drawing.Point(238, 294);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(118, 42);
            this.labelBrand.TabIndex = 1;
            this.labelBrand.Text = "Brand";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(238, 455);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(103, 42);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(238, 347);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(120, 42);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model";
            // 
            // pictureBoxFavorite
            // 
            this.pictureBoxFavorite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFavorite.Location = new System.Drawing.Point(1022, 174);
            this.pictureBoxFavorite.Name = "pictureBoxFavorite";
            this.pictureBoxFavorite.Size = new System.Drawing.Size(490, 497);
            this.pictureBoxFavorite.TabIndex = 4;
            this.pictureBoxFavorite.TabStop = false;
            // 
            // dataGridViewFavorites
            // 
            this.dataGridViewFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavorites.Location = new System.Drawing.Point(454, 174);
            this.dataGridViewFavorites.Name = "dataGridViewFavorites";
            this.dataGridViewFavorites.RowHeadersWidth = 51;
            this.dataGridViewFavorites.RowTemplate.Height = 24;
            this.dataGridViewFavorites.Size = new System.Drawing.Size(539, 497);
            this.dataGridViewFavorites.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Марка:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Модел:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(94, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(632, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 69);
            this.label4.TabIndex = 9;
            this.label4.Text = "Моите любими";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(29, 598);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(171, 58);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(58, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Година:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(238, 404);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(97, 42);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Year";
            // 
            // Favorite_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Задание.Properties.Resources.abstract_light_silver_background_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1581, 894);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFavorites);
            this.Controls.Add(this.pictureBoxFavorite);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.button_remove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Favorite_Cars";
            this.Text = "Favorite_Cars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.PictureBox pictureBoxFavorite;
        private System.Windows.Forms.DataGridView dataGridViewFavorites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelYear;
    }
}