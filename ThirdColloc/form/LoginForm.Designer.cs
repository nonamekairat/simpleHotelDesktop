namespace ThirdColloc
{
    partial class LoginForm
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
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            username = new Label();
            label2 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(242, 132);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(285, 27);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(242, 220);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(285, 27);
            passwordBox.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(242, 92);
            username.Name = "username";
            username.Size = new Size(187, 26);
            username.TabIndex = 2;
            username.Text = "имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(242, 186);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(312, 296);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(117, 47);
            loginButton.TabIndex = 4;
            loginButton.Text = "Логин";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 626);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label username;
        private Label label2;
        private Button loginButton;
    }
}