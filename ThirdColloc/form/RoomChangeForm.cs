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

namespace ThirdColloc.form
{
    public partial class RoomChangeForm : Form
    {
        RoomService _service;
        int roomId;
        public RoomChangeForm(int roomId)
        {
            this.roomId = roomId;
            InitializeComponent();
            _service = new RoomService();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(priceBox.Text);
            int number = int.Parse(numberBox.Text);
            string text = comboBox1.SelectedIndex == 0 ? "Lux" : comboBox1.SelectedIndex == 1 ? "Econom" : "Normal";
            RoomTypes type = (RoomTypes)Enum.Parse(typeof(RoomTypes), text);
            bool reserved = comboBox2.SelectedIndex == 0 ? true : false;

            Room room = new Room(roomId, number, type, reserved, price);
            _service.UpdateRoom(room);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
