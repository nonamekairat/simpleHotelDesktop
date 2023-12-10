﻿namespace ThirdColloc
{
    partial class ClientForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label5 = new Label();
            fromDatePicker = new DateTimePicker();
            toDatePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            searchButton = new Button();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 4;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 299F));
            table.Controls.Add(label4, 3, 0);
            table.Controls.Add(label3, 2, 0);
            table.Controls.Add(label2, 1, 0);
            table.Controls.Add(label1, 0, 0);
            table.Location = new Point(30, 111);
            table.Name = "table";
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.Size = new Size(763, 161);
            table.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(466, 0);
            label4.Name = "label4";
            label4.Size = new Size(294, 80);
            label4.TabIndex = 3;
            label4.Text = "Number of Guests";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(333, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 80);
            label3.TabIndex = 2;
            label3.Text = "Number of Guests";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(168, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 80);
            label2.TabIndex = 1;
            label2.Text = "Price";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 80);
            label1.TabIndex = 0;
            label1.Text = "Type";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 32);
            label5.Name = "label5";
            label5.Size = new Size(234, 20);
            label5.TabIndex = 1;
            label5.Text = "All our Available Rooms for today";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(77, 63);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(215, 27);
            fromDatePicker.TabIndex = 2;
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(345, 63);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(250, 27);
            toDatePicker.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 68);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 4;
            label6.Text = "from";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 68);
            label7.Name = "label7";
            label7.Size = new Size(23, 20);
            label7.TabIndex = 5;
            label7.Text = "to";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(616, 61);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 6;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 521);
            Controls.Add(searchButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(toDatePicker);
            Controls.Add(fromDatePicker);
            Controls.Add(label5);
            Controls.Add(table);
            Name = "ClientForm";
            Text = "ClientForm";
            Load += ClientForm_Load;
            table.ResumeLayout(false);
            table.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel table;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Label label6;
        private Label label7;
        private Button searchButton;
    }
}