using System;
using MvvmCross.Base;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using ToDo.Core.Services.Interfaces;
using ToDo.Core.Primitives;
using SQLite;


namespace ToDo.Core.Model
{
    public class ToDoTaskModel : MvxNotifyPropertyChanged, IToDoTask
    {
        private int _id;
        private ToDoTaskState _state;
        private string _text;

        public event EventHandler DeleteHandler;
        public event EventHandler EditHandler;
        public event EventHandler OkHandler;

        
        public ToDoTaskModel(ToDoTaskState state, string text)
        {
            
            State = state;
            Text = text;
        }


        public ToDoTaskModel()
        {

        }


        public IMvxCommand DeleteRecordCommand { get => new MvxCommand(() => DeleteHandler.Raise(this)); }
        public IMvxCommand EditRecordCommand { get => new MvxCommand(() => EditHandler.Raise(this)); }
        public IMvxCommand OkRecordCommand { get => new MvxCommand(() => OkHandler.Raise(this)); }


        [PrimaryKey]
        [AutoIncrement]
        public int Id
        {
            get => _id;
            set
            {
                SetProperty(ref _id, value);
            }
        }


        public ToDoTaskState State
        {
            get => _state;
            set
            {
                SetProperty(ref _state, value);
            }
        }


        public string Text
        {
            get => _text;
            set
            {
                SetProperty(ref _text, value);
            }
        }       
    }
}
