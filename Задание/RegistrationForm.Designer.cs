namespace Задание
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_confirmPassword = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_usernamee = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_BackToLogin = new System.Windows.Forms.Button();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(119, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Въведете всички полета, за да се регистрирате";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(224, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "РЕГИСТРАЦИЯ";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_username.Location = new System.Drawing.Point(269, 149);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(67, 20);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Имейл:";
            // 
            // label_confirmPassword
            // 
            this.label_confirmPassword.AutoSize = true;
            this.label_confirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_confirmPassword.Location = new System.Drawing.Point(171, 243);
            this.label_confirmPassword.Name = "label_confirmPassword";
            this.label_confirmPassword.Size = new System.Drawing.Size(165, 20);
            this.label_confirmPassword.TabIndex = 4;
            this.label_confirmPassword.Text = "Потвърди парола:";
            this.label_confirmPassword.Click += new System.EventHandler(this.label_confirmPassword_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_password.Location = new System.Drawing.Point(259, 213);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 20);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Парола:";
            // 
            // label_usernamee
            // 
            this.label_usernamee.AutoSize = true;
            this.label_usernamee.BackColor = System.Drawing.Color.Transparent;
            this.label_usernamee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_usernamee.Location = new System.Drawing.Point(154, 184);
            this.label_usernamee.Name = "label_usernamee";
            this.label_usernamee.Size = new System.Drawing.Size(182, 20);
            this.label_usernamee.TabIndex = 6;
            this.label_usernamee.Text = "Потребителско име:";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.label_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_phoneNumber.Location = new System.Drawing.Point(169, 277);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(167, 20);
            this.label_phoneNumber.TabIndex = 7;
            this.label_phoneNumber.Text = "Телефонен номер:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(346, 149);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(140, 22);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(346, 184);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(140, 22);
            this.textBoxUsername.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(346, 214);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(140, 22);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(346, 243);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(140, 22);
            this.textBoxConfirmPassword.TabIndex = 11;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(346, 275);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(416, 334);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(154, 55);
            this.button_Register.TabIndex = 13;
            this.button_Register.Text = "РЕГИСТРИРАЙ СЕ";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_BackToLogin
            // 
            this.button_BackToLogin.Location = new System.Drawing.Point(221, 334);
            this.button_BackToLogin.Name = "button_BackToLogin";
            this.button_BackToLogin.Size = new System.Drawing.Size(154, 55);
            this.button_BackToLogin.TabIndex = 14;
            this.button_BackToLogin.Text = "НАЗАД КЪМ ВЛИЗАНЕ";
            this.button_BackToLogin.UseVisualStyleBackColor = true;
            this.button_BackToLogin.Click += new System.EventHandler(this.button_BackToLogin_Click);
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_showPassword.Location = new System.Drawing.Point(493, 215);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(130, 20);
            this.checkBox_showPassword.TabIndex = 15;
            this.checkBox_showPassword.Text = "Покажи парола";
            this.checkBox_showPassword.UseVisualStyleBackColor = false;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Задание.Properties.Resources.abstract_light_silver_background_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_showPassword);
            this.Controls.Add(this.button_BackToLogin);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label_usernamee);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_confirmPassword);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_confirmPassword;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_usernamee;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_BackToLogin;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
    }
}