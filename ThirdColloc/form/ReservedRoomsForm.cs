using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdColloc.Models;
using ThirdColloc.Service;

namespace ThirdColloc
{
    public partial class ReservedRoomsForm : Form
    {
        ReservationService _service;
        RoomService roomService;
        int UserId;
        public ReservedRoomsForm(int UserId)
        {
            InitializeComponent();
            _service = new ReservationService();
            roomService = new RoomService();
            this.UserId = UserId;
        }

        private void ReservedRoomsForm_Load(object sender, EventArgs e)
        {


            List<Reservation> availableRooms = _service.GetAllReservationsByUserId(UserId);
            int newRow = 2;

            for (int i = 0; i < availableRooms.Count; i++)
            {

                Reservation reservation = availableRooms[i];
                Room room = roomService.GetRoomById(reservation.RoomId);
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

                Label fromLabel = new Label();
                fromLabel.TextAlign = ContentAlignment.MiddleCenter;
                fromLabel.Dock = DockStyle.Fill;
                fromLabel.Height = 40;
                fromLabel.Text = reservation.FromDate.ToString();

                Label toLabel = new Label();
                toLabel.TextAlign = ContentAlignment.MiddleCenter;
                toLabel.Dock = DockStyle.Fill;
                toLabel.Height = 40;
                toLabel.Text = reservation.ToDate.ToString();

                Button reserveButton = new Button();
                reserveButton.Dock = DockStyle.Fill;
                reserveButton.Text = "отменить";
                reserveButton.Click += (object sender, EventArgs e) =>
                {
                    _service.DeleteReservation(reservation.Id);
                };

                table.Controls.Add(typeLabel, 0, newRow);
                table.Controls.Add(priceLabel, 1, newRow);
                table.Controls.Add(numberLabel, 2, newRow);
                table.Controls.Add(fromLabel, 3, newRow);
                table.Controls.Add(toLabel, 4, newRow);
                table.Controls.Add(reserveButton, 5, newRow);


                newRow += 1;
                table.RowStyles.Add(newRowStyle);
            }

        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }
    }




}
