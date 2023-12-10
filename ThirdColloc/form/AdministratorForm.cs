using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ThirdColloc.Models;
using ThirdColloc.Service;
using ThirdColloc.form;

namespace ThirdColloc
{
    public partial class AdministratorForm : Form
    {
        public int UserId;
        public RoomService _service;
        public int rowCount;
        public AdministratorForm(int userId)
        {
            InitializeComponent();
            _service = new RoomService();
            this.UserId = userId;
            rowCount = 1;
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

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {

            DateTime fromDate = fromDatePicker.Value.Date;
            DateTime toDate = toDatePicker.Value.Date;

            List<Room> availableRooms = _service.GetAllRooms();
            if (rowCount > 1)
            {
                deleteRows();
            }
            int newRow = rowCount;

            for (int i = 0; i < availableRooms.Count; i++)
            {
                Room room = availableRooms[i];
                RowStyle newRowStyle = new RowStyle();


                Label idLabel = new Label();
                idLabel.TextAlign = ContentAlignment.MiddleCenter;
                idLabel.Dock = DockStyle.Fill;
                idLabel.Height = 40;
                idLabel.Text = (room.Id + 1).ToString();

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

                Label reservedLabel = new Label();
                reservedLabel.TextAlign = ContentAlignment.MiddleCenter;
                reservedLabel.Dock = DockStyle.Fill;
                reservedLabel.Height = 40;
                reservedLabel.Text = room.Reserved ? "Да" : "Нет";

                Button changeButton = new Button();
                changeButton.Dock = DockStyle.Fill;
                changeButton.Text = "изменить";
                changeButton.Click += (object sender, EventArgs e) =>
                {

                    RoomChangeForm roomChangeForm = new RoomChangeForm(room.Id);
                    roomChangeForm.ShowDialog();
                };

                Button reserveButton = new Button();
                reserveButton.Dock = DockStyle.Fill;
                reserveButton.Text = "бронировать";

                reserveButton.Click += (object sender, EventArgs e) =>
                {
                    Reservation reservation = new Reservation(fromDate, toDate, UserId, room.Id);
                    FinishReservationForm finish = new FinishReservationForm(reservation);
                    finish.ShowDialog();
                };

                table.Controls.Add(idLabel, 0, newRow);
                table.Controls.Add(priceLabel, 1, newRow);
                table.Controls.Add(numberLabel, 2, newRow);
                table.Controls.Add(typeLabel, 3, newRow);
                table.Controls.Add(reservedLabel, 4, newRow);
                table.Controls.Add(changeButton, 5, newRow);
                table.Controls.Add(reserveButton, 6, newRow);

                newRow += 1;
                table.RowStyles.Add(newRowStyle);
            }
            rowCount = newRow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(Roles.Reception.ToString());
            registerForm.ShowDialog();
        }
    }
}
