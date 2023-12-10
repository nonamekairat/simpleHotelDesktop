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
    public partial class FinishReservationForm : Form
    {

        ReservationService _service;
        Reservation reservation;
        public FinishReservationForm(Reservation reservation)
        {
            InitializeComponent();
            _service = new ReservationService();
            this.reservation = reservation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservation.Name = firstNameBox.Text + " " + lastNameBox.Text;
            _service.CreateReservation(reservation);
        }

        private void FinishReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
