namespace ThirdColloc
{
    partial class ReservedRoomsForm
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
            До = new Label();
            label4 = new Label();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 6;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.55073F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4492741F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            table.Controls.Add(label3, 2, 0);
            table.Controls.Add(label2, 1, 0);
            table.Controls.Add(label1, 0, 0);
            table.Controls.Add(От, 3, 0);
            table.Controls.Add(До, 4, 0);
            table.Location = new Point(109, 72);
            table.Name = "table";
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table.RowStyles.Add(new RowStyle());
            table.Size = new Size(733, 384);
            table.TabIndex = 1;
            table.Paint += table_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(241, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 40);
            label3.TabIndex = 2;
            label3.Text = "Количество мест";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(115, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
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
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "Тип комнаты";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // От
            // 
            От.AutoSize = true;
            От.Dock = DockStyle.Fill;
            От.Location = new Point(360, 0);
            От.Name = "От";
            От.Size = new Size(113, 40);
            От.TabIndex = 3;
            От.Text = "От";
            От.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // До
            // 
            До.AutoSize = true;
            До.Dock = DockStyle.Fill;
            До.Location = new Point(479, 0);
            До.Name = "До";
            До.Size = new Size(110, 40);
            До.TabIndex = 4;
            До.Text = "До";
            До.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(119, 27);
            label4.Name = "label4";
            label4.Size = new Size(312, 29);
            label4.TabIndex = 2;
            label4.Text = "Ваши действующие брони";
            // 
            // ReservedRoomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 480);
            Controls.Add(label4);
            Controls.Add(table);
            Name = "ReservedRoomsForm";
            Text = "ReservedRoomsForm";
            Load += ReservedRoomsForm_Load;
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
        private Label До;
        private Label label4;
    }
}