using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdColloc.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public RoomTypes Type { get; set; }
        public bool Reserved { get; set; }
        public decimal Price { get; set; }
    }
}
