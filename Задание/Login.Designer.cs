namespace Задание
{
    partial class Login
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_log_in = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(239, 85);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(76, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username: ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(239, 137);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password: ";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(321, 85);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 22);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(321, 131);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_log_in
            // 
            this.button_log_in.Location = new System.Drawing.Point(212, 197);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(100, 36);
            this.button_log_in.TabIndex = 5;
            this.button_log_in.Text = "Login";
            this.button_log_in.UseVisualStyleBackColor = true;
            this.button_log_in.Click += new System.EventHandler(this.button_log_in_Click);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(337, 197);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(100, 36);
            this.Register_button.TabIndex = 6;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Въведете потребителско име и парола, за да получите достъп.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ако нямате регистрация, въведете данните си и натиснете Register, за да се регист" +
    "рирате в системата.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
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
    }
}