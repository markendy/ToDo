using System;
using MvvmCross.Commands;
using ToDo.Core.Primitives;


namespace ToDo.Core.Services.Interfaces
{
    public interface IToDoTask
    {
        event EventHandler DeleteHandler;
        event EventHandler EditHandler;
        event EventHandler OkHandler;

        IMvxCommand DeleteRecordCommand { get; }
        IMvxCommand EditRecordCommand { get; }
        IMvxCommand OkRecordCommand { get; }

        int Id { get; set; }


        ToDoTaskState State { get; set; }


        string Text { get; set; }
    }
}
