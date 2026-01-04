namespace Задание
{
    partial class Login
    {
       
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_log_in = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Gainsboro;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.Location = new System.Drawing.Point(351, 271);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(185, 22);
            this.Username.TabIndex = 0;
            this.Username.Text = "Потребителско име: ";
            this.Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Gainsboro;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(453, 317);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(83, 22);
            this.Password.TabIndex = 2;
            this.Password.Text = "Парола: ";
            this.Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(572, 271);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(157, 22);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(572, 317);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(157, 22);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_log_in
            // 
            this.button_log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_log_in.Location = new System.Drawing.Point(478, 384);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(134, 51);
            this.button_log_in.TabIndex = 5;
            this.button_log_in.Text = "Влизане";
            this.button_log_in.UseVisualStyleBackColor = true;
            this.button_log_in.Click += new System.EventHandler(this.button_log_in_Click);
            // 
            // Register_button
            // 
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register_button.Location = new System.Drawing.Point(635, 384);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(188, 51);
            this.Register_button.TabIndex = 6;
            this.Register_button.Text = "Регистрация";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Въведете потребителско име и парола, за да получите достъп.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ако нямате регистрация, може да се регистрирате в системата.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_showPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_showPassword.Location = new System.Drawing.Point(737, 319);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(130, 20);
            this.checkBox_showPassword.TabIndex = 16;
            this.checkBox_showPassword.Text = "Покажи парола";
            this.checkBox_showPassword.UseVisualStyleBackColor = false;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 50);
            this.label3.TabIndex = 17;
            this.label3.Text = "Добре дошли в Cars";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_showPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
        private System.Windows.Forms.Label label3;
    }
}