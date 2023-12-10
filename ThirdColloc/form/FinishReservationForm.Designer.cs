namespace ThirdColloc
{
    partial class FinishReservationForm
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
            lastNameBox = new TextBox();
            firstNameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            reserveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(462, 37);
            label1.TabIndex = 0;
            label1.Text = "Расскажите о себе чуть больше <3";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(102, 135);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(125, 27);
            lastNameBox.TabIndex = 1;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(338, 135);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(125, 27);
            firstNameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 136);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 138);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 4;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 188);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 6;
            label4.Text = "Почта";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 27);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 241);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 8;
            label5.Text = "Телефон";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 27);
            textBox4.TabIndex = 7;
            // 
            // reserveButton
            // 
            reserveButton.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            reserveButton.Location = new Point(164, 359);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(199, 42);
            reserveButton.TabIndex = 9;
            reserveButton.Text = "зарезервировать";
            reserveButton.UseVisualStyleBackColor = true;
            reserveButton.Click += button1_Click;
            // 
            // FinishReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 479);
            Controls.Add(reserveButton);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(firstNameBox);
            Controls.Add(lastNameBox);
            Controls.Add(label1);
            Name = "FinishReservationForm";
            Text = "FinishReservationForm";
            Load += FinishReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lastNameBox;
        private TextBox firstNameBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button reserveButton;
    }
}