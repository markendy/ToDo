using System;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using ToDo.Core.Services;
using System.Collections.ObjectModel;
using ToDo.Core.Services.Interfaces;
using MvvmCross.Navigation;
using MvvmCross.IoC;
using MvvmCross;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ToDo.Core.ViewModel
{
    public class TipViewModel : MvxViewModel
    {
        private MvxObservableCollection<IToDoTask> _taskList;
        private readonly IFactory _factory;

        private readonly IMvxNavigationService _navigationService;

        private ITaskListTableManager _sql;


        public TipViewModel(IMvxNavigationService navigationService)
        {         
            _factory = Mvx.IoCProvider.Resolve<IFactory>();
            _taskList = new MvxObservableCollection<IToDoTask>();
            _navigationService = navigationService;           
        }


        public override Task Initialize()
        {
            if (_sql == null)
            {
                _sql = Mvx.IoCProvider.Resolve<ITaskListTableManager>();
            }

            TaskList.CollectionChanged += CollectionChanged;

            IEnumerable<IToDoTask> table = _sql.Load();
            foreach(var t in table)
            {
                TaskList.Add(t);
            }
            
            return base.Initialize();
        }


        public IMvxCommand AddRecordCommand => new MvxCommand(AddRecordExecute);


        public MvxObservableCollection<IToDoTask> TaskList
        {
            get => _taskList;
            set
            {
                SetProperty(ref _taskList, value);
            }
        }


        public void CollectionChanged(object sender, NotifyCollectionChangedEventArgs arg)
        {
            if(arg.NewItems != null)
            {
                foreach(var item in arg.NewItems)
                {
                    Subscribe((IToDoTask)item);
                }
            }
            if (arg.OldItems != null)
            {
                foreach (var item in arg.OldItems)
                {
                    UnSubscribe((IToDoTask)item);
                }
            }
        }


        private async void AddRecordExecute()
        {       
            var result = await _navigationService.Navigate<EditViewModel, EditViewModel.Result>();
            if (result.IsRejected)
            {
                return;
            }
            var task = _factory.Create(result.Text);
            TaskList.Add(task);
            _sql.Save(task);
        }


        private void DeleteRecordExecute(object sender, EventArgs arg)
        {
            if (!(sender is IToDoTask task))
            {
                return;
            }

            TaskList.Remove(task);
            _sql.Delete(task);
        }


        private void OkRecordExecute(object sender, EventArgs arg)
        {
            if (!(sender is IToDoTask task))
            {
                return;
            }
            // begin crutch
            switch (task.State)
            {
                case Primitives.ToDoTaskState.NotPerformed:
                    task.State = Primitives.ToDoTaskState.Performed;
                    break;

                case Primitives.ToDoTaskState.Performed:
                    task.State = Primitives.ToDoTaskState.NotPerformed;
                    break;
            }
            // end crutch
            
            _sql.Update(task);
        }


        private async void EditRecordExecute(object sender, EventArgs arg)
        {
            if (!(sender is IToDoTask task))
            {
                return;
            }
            var result = await _navigationService.Navigate<EditViewModel,
                EditViewModel.Parameter, EditViewModel.Result>(new EditViewModel.Parameter(task));
            if (result.IsRejected)
            {
                return;
            }
            task.Text = result.Text;

            _sql.Update(task);
        }


        private void Subscribe(IToDoTask task)
        {
            task.DeleteHandler += DeleteRecordExecute;
            task.EditHandler += EditRecordExecute;
            task.OkHandler += OkRecordExecute;
        }


        private void UnSubscribe(IToDoTask task)
        {
            task.DeleteHandler -= DeleteRecordExecute;
            task.EditHandler -= EditRecordExecute;
            task.OkHandler -= OkRecordExecute;
        }


        private void ResetTableOfList()
        {
            TaskList.Clear();
            _sql.RemoveTable();
        }
    }    
}
