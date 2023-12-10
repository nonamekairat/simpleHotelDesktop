namespace ThirdColloc
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            loginButton = new Button();
            registerButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(440, 213);
            label1.Name = "label1";
            label1.Size = new Size(249, 29);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать в";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(391, 359);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(162, 51);
            loginButton.TabIndex = 1;
            loginButton.Text = "Логин";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(601, 359);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(183, 51);
            registerButton.TabIndex = 2;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(391, 260);
            label2.Name = "label2";
            label2.Size = new Size(362, 43);
            label2.TabIndex = 3;
            label2.Text = "Отель \"Снежковый\"";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 677);
            Controls.Add(label2);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginButton;
        private Button registerButton;
        private Label label2;
    }
}