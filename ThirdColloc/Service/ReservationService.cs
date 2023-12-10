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
    public class ReservationService
    {
        private readonly ReservationDAO _reservationDAO;

        public ReservationService()
        {
            _reservationDAO = new ReservationDAO(Constants.connectionString);
        }

        public List<Reservation> GetAllReservations()
        {
            return _reservationDAO.GetAllReservations();
        }

        public Reservation GetReservationById(int reservationId)
        {
            return _reservationDAO.GetReservationById(reservationId);
        }

        public void CreateReservation(Reservation reservation)
        {
            _reservationDAO.CreateReservation(reservation);
        }

        public List<Reservation> GetAllReservationsByUserId(int userId)
        {
            return _reservationDAO.GetReservationsByUserId(userId);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _reservationDAO.UpdateReservation(reservation);
        }

        public void DeleteReservation(int reservationId)
        {
            _reservationDAO.DeleteReservation(reservationId);
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            return _reservationDAO.GetAvailableRooms(startDate, endDate);
        }
    }

}
