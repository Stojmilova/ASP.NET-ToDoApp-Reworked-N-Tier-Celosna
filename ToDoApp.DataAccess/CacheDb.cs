using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;

namespace ToDoApp.DataAccess
{
    public static class CacheDb
    {
        public static List<ToDoTask> _tasksDb;
        public static List<SubTask> _subtasksDb;
        public static List<User> _usersDb;
        public static int SubTaskId;
        public static int TaskId;
        public static int UserId;

        static CacheDb()
        {
            #region SubTask
            SubTask oneSubTask = new SubTask()
            {
                Id = 1,
                Title = "Invitation",
                Description = "Send invitations",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask twoSubTask = new SubTask()
            {
                Id = 2,
                Title = "Cake",
                Description = "Make the cake!",
                Status = TypeStatusSubTask.Done,
            };
            SubTask threeSubTask = new SubTask()
            {
                Id = 3,
                Title = "Tickets",
                Description = "Searching for flights",
                Status = TypeStatusSubTask.Done,
            };
            SubTask fourSubTask = new SubTask()
            {
                Id = 4,
                Title = "Picking the destination",
                Description = "Research hotels, tours, and attractions",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask fiveSubTask = new SubTask()
            {
                Id = 5,
                Title = "LayoutView",
                Description = "Create a layout with navigation for all views in application",
                Status = TypeStatusSubTask.Done,
            };
            SubTask sixSubTask = new SubTask()
            {
                Id = 6,
                Title = "First page",
                Description = "Create page which shown all tasks that are still not done",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask sevenSubTask = new SubTask()
            {
                Id = 7,
                Title = "Tripod",
                Description = "Bring a Tripod",
                Status = TypeStatusSubTask.Done,
            };
            SubTask eightSubTask = new SubTask()
            {
                Id = 8,
                Title = "Lens",
                Description = "Use the Right Lens",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask nineSubTask = new SubTask()
            {
                Id = 9,
                Title = "Design the a memorable logo",
                Description = "Make simple logo that all will actually remember.",
                Status = TypeStatusSubTask.Done,
            };
            SubTask tenSubTask = new SubTask()
            {
                Id = 10,
                Title = "Meeting",
                Description = "Meeting with the team about the ideas",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask elevenSubTask = new SubTask()
            {
                Id = 11,
                Title = "Better disign",
                Description = "Include bootstrap in project",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask twelveSubTask = new SubTask()
            {
                Id = 12,
                Title = "Buttons",
                Description = "Improved design of buttons",
                Status = TypeStatusSubTask.NotDone,
            };


            _subtasksDb = new List<SubTask>() { oneSubTask, twoSubTask, threeSubTask, fourSubTask, fiveSubTask, sixSubTask, sevenSubTask, eightSubTask, nineSubTask, tenSubTask, elevenSubTask, twelveSubTask };
            #endregion

            #region Task
            ToDoTask oneTask = new ToDoTask()
            {
                Id = 1,
                Title = "Create models and structure for the ToDo application",
                Description = "Application about done, not done, in progress Tasks and User statistics",
                Priority = TypePriority.MediumImportance,
                Status = TypeStatus.InProgress,
                TaskType = TypeOfTask.Work,
            };
            oneTask.SubTasks.Add(fiveSubTask);
            oneTask.SubTasks.Add(sixSubTask);

            ToDoTask twoTask = new ToDoTask()
            {
                Id = 2,
                Title = "BirthdayParty",
                Description = "Shopping and decoration",
                Priority = TypePriority.Important,
                Status = TypeStatus.Done,
                TaskType = TypeOfTask.Personal,
            };
            twoTask.SubTasks.Add(oneSubTask);
            twoTask.SubTasks.Add(twoSubTask);

            ToDoTask threeTask = new ToDoTask()
            {
                Id = 3,
                Title = "Travel",
                Description = "Organization of trip in Italy",
                Priority = TypePriority.NotImportant,
                Status = TypeStatus.NotDone,
                TaskType = TypeOfTask.Hobby,
            };
            threeTask.SubTasks.Add(threeSubTask);
            threeTask.SubTasks.Add(fourSubTask);

            ToDoTask fourTask = new ToDoTask()
            {
                Id = 4,
                Title = "Photo walk",
                Description = "Prepared for walk in nature",
                Priority = TypePriority.NotImportant,
                Status = TypeStatus.Done,
                TaskType = TypeOfTask.Hobby,
            };
            fourTask.SubTasks.Add(sevenSubTask);
            fourTask.SubTasks.Add(eightSubTask);

            ToDoTask fiveTask = new ToDoTask()
            {
                Id = 5,
                Title = "Logo",
                Description = "Design a new organization logo",
                Priority = TypePriority.MediumImportance,
                Status = TypeStatus.NotDone,
                TaskType = TypeOfTask.Work,
            };
            fiveTask.SubTasks.Add(nineSubTask);
            fiveTask.SubTasks.Add(tenSubTask);

            ToDoTask sixTask = new ToDoTask()
            {
                Id = 6,
                Title = "Drop down",
                Description = "Make drop down menus scrollable",
                Priority = TypePriority.Important,
                Status = TypeStatus.NotDone,
                TaskType = TypeOfTask.Work,
            };
            sixTask.SubTasks.Add(elevenSubTask);
            sixTask.SubTasks.Add(twelveSubTask);


            _tasksDb = new List<ToDoTask>() { oneTask, twoTask, threeTask, fourTask, fiveTask, sixTask };
            #endregion
            #region User
            User oneUser = new User()
            {
                Id = 1,
                FirstName = "Anna",
                LastName = "Benton",
                Age = 28,
                AverageFreeTime = 2.5M,
                Email = "anna.b@gmail.com"
            };
            oneUser.CreatedTasks.Add(oneTask);
            oneUser.CreatedTasks.Add(threeTask);
            oneUser.CreatedTasks.Add(fourTask);

            User twoUser = new User()
            {
                Id = 2,
                FirstName = "Smith",
                LastName = "Anderson",
                Age = 29,
                AverageFreeTime = 1.2M,
                Email = "smith.a@gmail.com"
            };
            twoUser.CreatedTasks.Add(oneTask);
            twoUser.CreatedTasks.Add(twoTask);
            twoUser.CreatedTasks.Add(fiveTask);

            User threeUser = new User()
            {
                Id = 3,
                FirstName = "Megan",
                LastName = "Morton",
                Age = 30,
                AverageFreeTime = 3.7M,
                Email = "megan.m@gmail.com"
            };
            threeUser.CreatedTasks.Add(oneTask);
            threeUser.CreatedTasks.Add(twoTask);
            threeUser.CreatedTasks.Add(threeTask);
            threeUser.CreatedTasks.Add(fiveTask);
            ;

            _usersDb = new List<User>() { oneUser, twoUser, threeUser };

            #endregion

            SubTaskId = 12;
            TaskId = 6;
            UserId = 3;
        }
    }
}
