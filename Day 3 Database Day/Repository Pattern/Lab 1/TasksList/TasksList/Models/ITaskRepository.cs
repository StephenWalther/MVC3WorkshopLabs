using System;
namespace TasksList.Models
{
   public interface ITaskRepository
    {
        Task CreateTask(Task taskToCreate);
        Task EditTask(Task taskToEdit);
        Task GetTask(int Id);
        System.Collections.Generic.List<Person> PersonsList();
        System.Linq.IQueryable<Task> TasksByPerson(int personId);
        System.Linq.IQueryable<Task> TasksList();
    }
}
