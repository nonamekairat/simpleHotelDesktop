using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdColloc.Service;
using ThirdColloc.Models;

namespace ThirdColloc
{
    public partial class ClientForm : Form
    {

        public ReservationService _service;
        public int UserId;
        public int rowCount;
        public ClientForm(int UserId)
        {
            InitializeComponent();
            _service = new ReservationService();
            this.UserId = UserId;
            rowCount = 1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteRows()
        {


            for (int j = 1; j < rowCount; j++)
            {
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    Control control = table.GetControlFromPosition(i, j);
                    if (control != null)
                    {
                        table.Controls.Remove(control);
                        control.Dispose(); // Dispose the control if needed
                    }
                }
            }

            rowCount = 1;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            DateTime fromDate = fromDatePicker.Value.Date;
            DateTime toDate = toDatePicker.Value.Date;

            List<Room> availableRooms = _service.GetAvailableRooms(fromDate, toDate);
            if (rowCount > 1)
            {
                deleteRows();
            }
            int newRow = rowCount;

            for (int i = 0; i < availableRooms.Count; i++)
            {
                Room room = availableRooms[i];
                RowStyle newRowStyle = new RowStyle();
                Label typeLabel = new Label();
                typeLabel.TextAlign = ContentAlignment.MiddleCenter;
                typeLabel.Dock = DockStyle.Fill;
                typeLabel.Height = 40;
                typeLabel.Text = room.Type.ToString();

                Label priceLabel = new Label();
                priceLabel.TextAlign = ContentAlignment.MiddleCenter;
                priceLabel.Dock = DockStyle.Fill;
                priceLabel.Height = 40;
                priceLabel.Text = room.Price.ToString();

                Label numberLabel = new Label();
                numberLabel.TextAlign = ContentAlignment.MiddleCenter;
                numberLabel.Dock = DockStyle.Fill;
                numberLabel.Height = 40;
                numberLabel.Text = room.Number.ToString();

                Button reserveButton = new Button();
                reserveButton.Dock = DockStyle.Fill;
                reserveButton.Text = "зарезервировать";
                reserveButton.Click += (object sender, EventArgs e) =>
                {
                    Reservation reservation = new Reservation(fromDate, toDate, UserId, room.Id);
                    FinishReservationForm finishReservationForm = new FinishReservationForm(reservation);
                    finishReservationForm.ShowDialog();
                };

                table.Controls.Add(typeLabel, 0, newRow);
                table.Controls.Add(priceLabel, 1, newRow);
                table.Controls.Add(numberLabel, 2, newRow);
                table.Controls.Add(reserveButton, 3, newRow);


                newRow += 1;
                table.RowStyles.Add(newRowStyle);
            }
            rowCount = newRow;
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReservedRoomsForm reservedRoomsForm = new ReservedRoomsForm(UserId);
            reservedRoomsForm.ShowDialog();
        }
    }
}
