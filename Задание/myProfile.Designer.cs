namespace Задание
{
    partial class myProfile
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
            this.label_myProfile = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_confirmNewPassword = new System.Windows.Forms.Label();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.label_oldPassword = new System.Windows.Forms.Label();
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_confirmNewPassword = new System.Windows.Forms.TextBox();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.textBox_oldPassword = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_myProfile
            // 
            this.label_myProfile.AutoSize = true;
            this.label_myProfile.BackColor = System.Drawing.Color.Transparent;
            this.label_myProfile.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Italic);
            this.label_myProfile.Location = new System.Drawing.Point(273, 48);
            this.label_myProfile.Name = "label_myProfile";
            this.label_myProfile.Size = new System.Drawing.Size(208, 39);
            this.label_myProfile.TabIndex = 0;
            this.label_myProfile.Text = "Моят профил";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_username.Location = new System.Drawing.Point(168, 123);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(187, 20);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Потребителско име: ";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.label_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_phoneNumber.Location = new System.Drawing.Point(183, 251);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(172, 20);
            this.label_phoneNumber.TabIndex = 2;
            this.label_phoneNumber.Text = "Телефонен номер: ";
            // 
            // label_confirmNewPassword
            // 
            this.label_confirmNewPassword.AutoSize = true;
            this.label_confirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_confirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_confirmNewPassword.Location = new System.Drawing.Point(153, 216);
            this.label_confirmNewPassword.Name = "label_confirmNewPassword";
            this.label_confirmNewPassword.Size = new System.Drawing.Size(202, 20);
            this.label_confirmNewPassword.TabIndex = 3;
            this.label_confirmNewPassword.Text = "Повтори нова парола: ";
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_newPassword.Location = new System.Drawing.Point(228, 182);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(127, 20);
            this.label_newPassword.TabIndex = 4;
            this.label_newPassword.Text = "Нова парола: ";
            this.label_newPassword.Click += new System.EventHandler(this.label_newPassword_Click);
            // 
            // label_oldPassword
            // 
            this.label_oldPassword.AutoSize = true;
            this.label_oldPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_oldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_oldPassword.Location = new System.Drawing.Point(219, 153);
            this.label_oldPassword.Name = "label_oldPassword";
            this.label_oldPassword.Size = new System.Drawing.Size(136, 20);
            this.label_oldPassword.TabIndex = 5;
            this.label_oldPassword.Text = "Стара парола: ";
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_saveChanges.Location = new System.Drawing.Point(161, 326);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(214, 71);
            this.button_saveChanges.TabIndex = 6;
            this.button_saveChanges.Text = "Запази промените";
            this.button_saveChanges.UseVisualStyleBackColor = true;
            this.button_saveChanges.Click += new System.EventHandler(this.button_saveChanges_Click);
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.Location = new System.Drawing.Point(398, 326);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(205, 71);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Затвори";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(381, 123);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(129, 22);
            this.textBox_username.TabIndex = 8;
            // 
            // textBox_confirmNewPassword
            // 
            this.textBox_confirmNewPassword.Location = new System.Drawing.Point(381, 216);
            this.textBox_confirmNewPassword.Name = "textBox_confirmNewPassword";
            this.textBox_confirmNewPassword.Size = new System.Drawing.Size(129, 22);
            this.textBox_confirmNewPassword.TabIndex = 9;
            this.textBox_confirmNewPassword.UseSystemPasswordChar = true;
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Location = new System.Drawing.Point(381, 182);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.Size = new System.Drawing.Size(129, 22);
            this.textBox_newPassword.TabIndex = 10;
            this.textBox_newPassword.UseSystemPasswordChar = true;
            // 
            // textBox_oldPassword
            // 
            this.textBox_oldPassword.Location = new System.Drawing.Point(381, 153);
            this.textBox_oldPassword.Name = "textBox_oldPassword";
            this.textBox_oldPassword.Size = new System.Drawing.Size(129, 22);
            this.textBox_oldPassword.TabIndex = 11;
            this.textBox_oldPassword.UseSystemPasswordChar = true;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(381, 251);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(129, 22);
            this.textBox_phoneNumber.TabIndex = 12;
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_showPassword.Location = new System.Drawing.Point(535, 182);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(130, 20);
            this.checkBox_showPassword.TabIndex = 13;
            this.checkBox_showPassword.Text = "Покажи парола";
            this.checkBox_showPassword.UseVisualStyleBackColor = false;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // myProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Задание.Properties.Resources._549bc333_afad_4942_942f_6c0886043095;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_showPassword);
            this.Controls.Add(this.textBox_phoneNumber);
            this.Controls.Add(this.textBox_oldPassword);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.textBox_confirmNewPassword);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_saveChanges);
            this.Controls.Add(this.label_oldPassword);
            this.Controls.Add(this.label_newPassword);
            this.Controls.Add(this.label_confirmNewPassword);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_myProfile);
            this.Name = "myProfile";
            this.Text = " ";
            this.Load += new System.EventHandler(this.myProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_myProfile;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_confirmNewPassword;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.Label label_oldPassword;
        private System.Windows.Forms.Button button_saveChanges;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_confirmNewPassword;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.TextBox textBox_oldPassword;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
    }
}