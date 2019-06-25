using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain.Models;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteBy(int id)
        {
            User user = CacheDb._usersDb.FirstOrDefault(x => x.Id == id);
            if (user != null) CacheDb._usersDb.Remove(user);
        }

        public List<User> GetAll()
        {
            return CacheDb._usersDb;
        }

        public User GetById(int Id)
        {
            User user = CacheDb._usersDb.FirstOrDefault(x => x.Id == Id);
            return user;
        }

        public void Insert(User entity)
        {
            CacheDb.UserId++;
            entity.Id = CacheDb.UserId;
            CacheDb._usersDb.Add(entity);
        }

        public void Update(User entity)
        {
            User user = CacheDb._usersDb.FirstOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                int index = CacheDb._usersDb.IndexOf(user);
                CacheDb._usersDb[index] = entity;
            }
        }
    }
}
