using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain.Models;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        public void DeleteBy(int id)
        {
            SubTask subTask = CacheDb._subtasksDb.FirstOrDefault(x => x.Id == id);
            if (subTask != null) CacheDb._subtasksDb.Remove(subTask);
        }

        public List<SubTask> GetAll()
        {
            return CacheDb._subtasksDb;
        }

        public SubTask GetById(int Id)
        {
            SubTask subTask = CacheDb._subtasksDb.FirstOrDefault(x => x.Id == Id);
            return subTask;
        }

        public void Insert(SubTask entity)
        {
            CacheDb.SubTaskId++;
            entity.Id = CacheDb.SubTaskId;
            CacheDb._subtasksDb.Add(entity);
        }

        public void Update(SubTask entity)
        {
            SubTask subTask = CacheDb._subtasksDb.FirstOrDefault(x => x.Id == entity.Id);
            if (subTask != null)
            {
                int index = CacheDb._subtasksDb.IndexOf(subTask);
                CacheDb._subtasksDb[index] = entity;
            }
        }
    }
}
