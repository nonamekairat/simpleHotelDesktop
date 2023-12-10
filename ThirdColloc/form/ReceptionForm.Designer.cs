namespace ThirdColloc
{
    partial class ReceptionForm
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
            table = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            От = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            toDatePicker = new DateTimePicker();
            fromDatePicker = new DateTimePicker();
            updateButton = new Button();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 6;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.55073F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2713871F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2536869F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.8761063F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            table.Controls.Add(label3, 2, 0);
            table.Controls.Add(label2, 1, 0);
            table.Controls.Add(label1, 0, 0);
            table.Controls.Add(От, 3, 0);
            table.Controls.Add(label4, 4, 0);
            table.Location = new Point(41, 91);
            table.Name = "table";
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table.RowStyles.Add(new RowStyle());
            table.Size = new Size(894, 384);
            table.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(275, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 40);
            label3.TabIndex = 2;
            label3.Text = "Количество мест";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(143, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 40);
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
            label1.Size = new Size(134, 40);
            label1.TabIndex = 0;
            label1.Text = "Номер";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // От
            // 
            От.AutoSize = true;
            От.Dock = DockStyle.Fill;
            От.Location = new Point(431, 0);
            От.Name = "От";
            От.Size = new Size(159, 40);
            От.TabIndex = 3;
            От.Text = "Тип";
            От.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(596, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 40);
            label4.TabIndex = 4;
            label4.Text = "Зарезервировано";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 47);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 14;
            label7.Text = "до";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 47);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 13;
            label6.Text = "от";
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(546, 42);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(250, 27);
            toDatePicker.TabIndex = 12;
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(278, 42);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(215, 27);
            fromDatePicker.TabIndex = 11;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(818, 32);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(117, 40);
            updateButton.TabIndex = 10;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // ReceptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 497);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(toDatePicker);
            Controls.Add(fromDatePicker);
            Controls.Add(updateButton);
            Controls.Add(table);
            Name = "ReceptionForm";
            Text = "ReceptionForm";
            Load += ReceptionForm_Load;
            table.ResumeLayout(false);
            table.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel table;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label От;
        private Label label4;
        private Label label7;
        private Label label6;
        private DateTimePicker toDatePicker;
        private DateTimePicker fromDatePicker;
        private Button updateButton;
    }
}