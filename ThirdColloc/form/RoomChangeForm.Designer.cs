namespace ThirdColloc.form
{
    partial class RoomChangeForm
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
            label3 = new Label();
            label2 = new Label();
            numberBox = new TextBox();
            label1 = new Label();
            priceBox = new TextBox();
            changeButton = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 146);
            label3.Name = "label3";
            label3.Size = new Size(46, 26);
            label3.TabIndex = 8;
            label3.Text = "Тип";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(176, 26);
            label2.TabIndex = 7;
            label2.Text = "Количество Мест";
            // 
            // numberBox
            // 
            numberBox.Location = new Point(33, 89);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(437, 27);
            numberBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 217);
            label1.Name = "label1";
            label1.Size = new Size(58, 26);
            label1.TabIndex = 10;
            label1.Text = "Цена";
            // 
            // priceBox
            // 
            priceBox.Location = new Point(33, 246);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(434, 27);
            priceBox.TabIndex = 9;
            // 
            // changeButton
            // 
            changeButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeButton.Location = new Point(165, 443);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(135, 61);
            changeButton.TabIndex = 11;
            changeButton.Text = "изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 294);
            label4.Name = "label4";
            label4.Size = new Size(175, 26);
            label4.TabIndex = 13;
            label4.Text = "Зарезервировано";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lux", "Econom", "Normal" });
            comboBox1.Location = new Point(33, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "да", "нет" });
            comboBox2.Location = new Point(33, 332);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 15;
            // 
            // RoomChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 551);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(changeButton);
            Controls.Add(label1);
            Controls.Add(priceBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numberBox);
            Name = "RoomChangeForm";
            Text = "RoomChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox numberBox;
        private Label label1;
        private TextBox priceBox;
        private Button changeButton;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}