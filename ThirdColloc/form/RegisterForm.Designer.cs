namespace ThirdColloc
{
    partial class RegisterForm
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
            label1 = new Label();
            confirmPasswordBox = new TextBox();
            label2 = new Label();
            username = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 242);
            label1.Name = "label1";
            label1.Size = new Size(205, 26);
            label1.TabIndex = 11;
            label1.Text = "подтвердите пароль";
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(252, 281);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.PasswordChar = '*';
            confirmPasswordBox.Size = new Size(345, 27);
            confirmPasswordBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(252, 162);
            label2.Name = "label2";
            label2.Size = new Size(77, 26);
            label2.TabIndex = 9;
            label2.Text = "пароль";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(252, 82);
            username.Name = "username";
            username.Size = new Size(187, 26);
            username.TabIndex = 8;
            username.Text = "имя пользователя";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(252, 202);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(345, 27);
            passwordBox.TabIndex = 7;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(252, 122);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(345, 27);
            usernameBox.TabIndex = 6;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(328, 363);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(192, 61);
            registerButton.TabIndex = 12;
            registerButton.Text = "регистрация";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 562);
            Controls.Add(registerButton);
            Controls.Add(label1);
            Controls.Add(confirmPasswordBox);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox confirmPasswordBox;
        private Label label2;
        private Label username;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button registerButton;
    }
}