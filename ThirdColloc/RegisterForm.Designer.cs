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
            label1.Location = new Point(271, 262);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 11;
            label1.Text = "confirm password";
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(404, 259);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.PasswordChar = '*';
            confirmPasswordBox.Size = new Size(125, 27);
            confirmPasswordBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 215);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "password";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(326, 167);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 8;
            username.Text = "username";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(404, 212);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(125, 27);
            passwordBox.TabIndex = 7;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(405, 164);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(125, 27);
            usernameBox.TabIndex = 6;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(405, 312);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 12;
            registerButton.Text = "register";
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