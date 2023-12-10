using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdColloc.Models;

namespace ThirdColloc.Repository
{
    public class ReservationDAO
    {
        private readonly string _connectionString;

        public ReservationDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Reservation> GetAllReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM reservation";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(new Reservation
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                FromDate = Convert.ToDateTime(reader["from_date"]),
                                ToDate = Convert.ToDateTime(reader["to_date"]),
                                Name = Convert.ToString(reader["name"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                RoomId = Convert.ToInt32(reader["room_id"])
                            });
                        }
                    }
                }
            }

            return reservations;
        }

        public Reservation GetReservationById(int reservationId)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM reservation WHERE id = @ReservationId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationId", reservationId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Reservation
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                FromDate = Convert.ToDateTime(reader["from_date"]),
                                ToDate = Convert.ToDateTime(reader["to_date"]),
                                Name = Convert.ToString(reader["name"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                RoomId = Convert.ToInt32(reader["room_id"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void CreateReservation(Reservation reservation)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "INSERT INTO reservation (from_date, to_date, name, user_id, room_id) VALUES (@FromDate, @ToDate, @Name, @UserId, @RoomId)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FromDate", reservation.FromDate);
                    command.Parameters.AddWithValue("@ToDate", reservation.ToDate);
                    command.Parameters.AddWithValue("@Name", reservation.Name);
                    command.Parameters.AddWithValue("@UserId", reservation.UserId);
                    command.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateReservation(Reservation reservation)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "UPDATE reservation SET from_date = @FromDate, to_date = @ToDate, name=@Name user_id = @UserId, room_id = @RoomId WHERE id = @ReservationId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FromDate", reservation.FromDate);
                    command.Parameters.AddWithValue("@ToDate", reservation.ToDate);
                    command.Parameters.AddWithValue("@Name", reservation.Name);
                    command.Parameters.AddWithValue("@UserId", reservation.UserId);
                    command.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                    command.Parameters.AddWithValue("@ReservationId", reservation.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteReservation(int reservationId)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "DELETE FROM reservation WHERE id = @ReservationId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationId", reservationId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Reservation> GetReservationsBetweenDates(DateTime startDate, DateTime endDate)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM reservation WHERE from_date >= @StartDate AND to_date <= @EndDate";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(new Reservation
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                FromDate = Convert.ToDateTime(reader["from_date"]),
                                ToDate = Convert.ToDateTime(reader["to_date"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                RoomId = Convert.ToInt32(reader["room_id"])
                            });
                        }
                    }
                }
            }

            return reservations;
        }


        public List<Reservation> GetReservationsByUserId(int userId)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM reservation WHERE user_id = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(new Reservation
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                FromDate = Convert.ToDateTime(reader["from_date"]),
                                ToDate = Convert.ToDateTime(reader["to_date"]),
                                Name = Convert.ToString(reader["name"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                RoomId = Convert.ToInt32(reader["room_id"])
                            });
                        }
                    }
                }
            }

            return reservations;
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            List<Room> availableRooms = new List<Room>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = @"
                SELECT * 
                FROM room
                WHERE id NOT IN (
                    SELECT room_id FROM reservation WHERE from_date >= @StartDate AND to_date <= @EndDate
                )";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableRooms.Add(new Room
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Number = Convert.ToInt32(reader["number"]),
                                Type = (RoomTypes) Enum.Parse(typeof(RoomTypes), reader["type"].ToString()),
                                Reserved = Convert.ToBoolean(reader["reserved"]),
                                Price = Convert.ToDecimal(reader["price"])
                            });
                        }
                    }
                }
            }

            return availableRooms;
        }


    }

}
