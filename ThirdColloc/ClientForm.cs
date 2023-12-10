using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdColloc
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            RowStyle newRowStyle = new RowStyle(SizeType.AutoSize);

            // Add the new row style to the TableLayoutPanel
            table.RowStyles.Add(newRowStyle);

            // Add controls to the new row
            // For example, adding a TextBox and a Button to the new row
            Label textBox = new Label();

            // Set properties, add event handlers, etc. for the controls if needed
            // ...

            // Add controls to the TableLayoutPanel at the specified row and column
            int newRow = table.RowCount - 1; // The index of the new row
            table.Controls.Add(textBox, 0, newRow); // Add TextBox at column 0
            table.Controls.Add(button, 1, newRow); // Add Button at column 1
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
