using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain.Models;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class ToDoTaskRepository : IRepository<ToDoTask>
    {

        public void DeleteBy(int id)
        {
            ToDoTask toDoTask = CacheDb._tasksDb.FirstOrDefault(x => x.Id == id);
            if (toDoTask != null) CacheDb._tasksDb.Remove(toDoTask);
        }

        public List<ToDoTask> GetAll()
        {
            return CacheDb._tasksDb;
        }

        public ToDoTask GetById(int Id)
        {
            ToDoTask toDoTask = CacheDb._tasksDb.FirstOrDefault(x => x.Id == Id);
            return toDoTask;
        }

        public void Insert(ToDoTask entity)
        {
            CacheDb.TaskId++;
            entity.Id = CacheDb.TaskId;
            foreach (var item in entity.SubTasks)
            {
                item.TaskID = CacheDb.TaskId;
            }
            CacheDb._tasksDb.Add(entity);
        }

        public void Update(ToDoTask entity)
        {
            ToDoTask toDoTask = CacheDb._tasksDb.FirstOrDefault(x => x.Id == entity.Id);
            if (toDoTask != null)
            {
                int index = CacheDb._tasksDb.IndexOf(toDoTask);
                CacheDb._tasksDb[index] = entity;
            }
        }
    }
}
