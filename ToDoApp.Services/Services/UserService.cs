using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> _userRepo)
        {
            _userRepository = _userRepo;

        }
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
