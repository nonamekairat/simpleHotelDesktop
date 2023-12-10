using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdColloc.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public string Name { get; set; }
        public DateTime ToDate { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
    }
}
