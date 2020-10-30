using ToDo.Core.Services.Interfaces;
using ToDo.Core.ViewModel;


namespace ToDo.Core.Services.Interfaces
{
    public interface IFactory
    {
        IToDoTask Create(string text);
    }
}
