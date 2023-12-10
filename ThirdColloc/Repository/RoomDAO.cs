using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdColloc.Models;

namespace ThirdColloc.Repository
{
    public class RoomDAO
    {
        private readonly string _connectionString;

        public RoomDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM room";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Number = Convert.ToInt32(reader["number"]),
                                Type = (RoomTypes)Enum.Parse(typeof(RoomTypes), reader["type"].ToString()),
                                Reserved = Convert.ToBoolean(reader["reserved"]),
                                Price = Convert.ToDecimal(reader["price"])
                            });
                        }
                    }
                }
            }

            return rooms;
        }

        public Room GetRoomById(int roomId)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM room WHERE id = @RoomId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Room
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Number = Convert.ToInt32(reader["number"]),
                                Type = (RoomTypes)Enum.Parse(typeof(RoomTypes), reader["type"].ToString()),
                                Reserved = Convert.ToBoolean(reader["reserved"]),
                                Price = Convert.ToDecimal(reader["price"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void CreateRoom(Room room)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "INSERT INTO room (number, type, reserved, price) VALUES (@Number, @Type, @Reserved, @Price)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Number", room.Number);
                    command.Parameters.AddWithValue("@Type", room.Type.ToString());
                    command.Parameters.AddWithValue("@Reserved", room.Reserved);
                    command.Parameters.AddWithValue("@Price", room.Price);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRoom(Room room)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "UPDATE room SET number = @Number, type = @Type, reserved = @Reserved, price = @Price WHERE id = @RoomId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Number", room.Number);
                    command.Parameters.AddWithValue("@Type", room.Type.ToString());
                    command.Parameters.AddWithValue("@Reserved", room.Reserved);
                    command.Parameters.AddWithValue("@Price", room.Price);
                    command.Parameters.AddWithValue("@RoomId", room.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRoom(int roomId)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "DELETE FROM room WHERE id = @RoomId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
