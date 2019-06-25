using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int Id);
        void DeleteBy(int id);
        void Update(T entity);
        void Insert(T entity);

    }
}
