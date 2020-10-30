using ToDo.Core.Services.Interfaces;
using ToDo.Core.Model;
using ToDo.Core.Primitives;


namespace ToDo.Core.Services
{
    public class TaskFactory : IFactory
    {
        public TaskFactory()
        {
            
        }


        public IToDoTask Create(string text)
        {
            return new ToDoTaskModel(ToDoTaskState.NotPerformed, text);
        }
    }
}
