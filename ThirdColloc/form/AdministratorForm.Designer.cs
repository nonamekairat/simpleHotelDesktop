namespace ThirdColloc
{
    partial class AdministratorForm
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
            registerButton = new Button();
            table = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            От = new Label();
            label4 = new Label();
            label5 = new Label();
            updateButton = new Button();
            label7 = new Label();
            label6 = new Label();
            toDatePicker = new DateTimePicker();
            fromDatePicker = new DateTimePicker();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(615, 31);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(323, 40);
            registerButton.TabIndex = 0;
            registerButton.Text = "Зарегистировать нового сотрудника";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // table
            // 
            table.ColumnCount = 7;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.55073F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2713871F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2536869F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.8761063F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            table.Controls.Add(label3, 2, 0);
            table.Controls.Add(label2, 1, 0);
            table.Controls.Add(label1, 0, 0);
            table.Controls.Add(От, 3, 0);
            table.Controls.Add(label4, 4, 0);
            table.Location = new Point(24, 150);
            table.Name = "table";
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table.RowStyles.Add(new RowStyle());
            table.Size = new Size(930, 384);
            table.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(256, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 40);
            label3.TabIndex = 2;
            label3.Text = "Количество мест";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(133, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 40);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 40);
            label1.TabIndex = 0;
            label1.Text = "Номер";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // От
            // 
            От.AutoSize = true;
            От.Dock = DockStyle.Fill;
            От.Location = new Point(401, 0);
            От.Name = "От";
            От.Size = new Size(148, 40);
            От.TabIndex = 3;
            От.Text = "Тип";
            От.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(555, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 40);
            label4.TabIndex = 4;
            label4.Text = "Зарезервировано";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 31);
            label5.Name = "label5";
            label5.Size = new Size(554, 29);
            label5.TabIndex = 3;
            label5.Text = "Добро пожаловать уважаемый администратор";
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(836, 105);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(102, 29);
            updateButton.TabIndex = 4;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(510, 109);
            label7.Name = "label7";
            label7.Size = new Size(23, 20);
            label7.TabIndex = 9;
            label7.Text = "to";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 109);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 8;
            label6.Text = "from";
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(548, 104);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(250, 27);
            toDatePicker.TabIndex = 7;
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(280, 104);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(215, 27);
            fromDatePicker.TabIndex = 6;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 682);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(toDatePicker);
            Controls.Add(fromDatePicker);
            Controls.Add(updateButton);
            Controls.Add(label5);
            Controls.Add(table);
            Controls.Add(registerButton);
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            Load += AdministratorForm_Load;
            table.ResumeLayout(false);
            table.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TableLayoutPanel table;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label От;
        private Label label4;
        private Label label5;
        private Button updateButton;
        private Label label7;
        private Label label6;
        private DateTimePicker toDatePicker;
        private DateTimePicker fromDatePicker;
    }
}