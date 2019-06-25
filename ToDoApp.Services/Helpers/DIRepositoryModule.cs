using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.DataAccess.Repositories.CacheRepositories;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<ToDoTask>, ToDoTaskRepository>();
            services.AddTransient<IRepository<SubTask>, SubTaskRepository>();           
            return services;
        }
    }
}
