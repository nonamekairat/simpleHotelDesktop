using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdColloc.Models;
using ThirdColloc.Repository;
using ThirdColloc.util;

namespace ThirdColloc.Service
{
    public class RoomService
    {
        private readonly RoomDAO _roomDAO;

        public RoomService()
        {
            _roomDAO = new RoomDAO(Constants.connectionString);
        }

        public List<Room> GetAllRooms()
        {
            return _roomDAO.GetAllRooms();
        }

        public Room GetRoomById(int roomId)
        {
            return _roomDAO.GetRoomById(roomId);
        }

        public void CreateRoom(Room room)
        {
            _roomDAO.CreateRoom(room);
        }

        public void UpdateRoom(Room room)
        {
            _roomDAO.UpdateRoom(room);
        }

        public void DeleteRoom(int roomId)
        {
            _roomDAO.DeleteRoom(roomId);
        }
    }

}
