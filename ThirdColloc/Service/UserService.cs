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
    public class UserService
    {
        private readonly UserDAO _userDAO;

        public UserService()
        {
            _userDAO = new UserDAO(Constants.connectionString);
        }

        public void RegisterUser(User user)
        {
            CreateUser(user);
        }

        public User LoginUser(String username, String password)
        {
            User user = GetUserByUsernameAndPassword(username, password);
            return user;
            
        }

        public List<User> GetAllUsers()
        {
            return _userDAO.GetAllUsers();
        }

        public User GetUserByUsername(string username)
        {
            return _userDAO.GetUserByUsername(username);
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return _userDAO.GetUserByUsernameAndPassword(username, password);
        }

        public User GetUserById(int userId)
        {
            return _userDAO.GetUserById(userId);
        }

        public void CreateUser(User user)
        {
            _userDAO.CreateUser(user);
        }

        public void UpdateUser(User user)
        {
            _userDAO.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userDAO.DeleteUser(userId);
        }
    }

}
