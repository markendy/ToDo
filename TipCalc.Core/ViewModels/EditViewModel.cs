using MvvmCross.ViewModels;
using MvvmCross.Commands;
using ToDo.Core.Services.Interfaces;
using static ToDo.Core.ViewModel.EditViewModel;
using MvvmCross.Navigation;


namespace ToDo.Core.ViewModel
{
    public class EditViewModel : MvxViewModel<Parameter, Result>
    {
        private readonly IMvxNavigationService _navigationService;

        private string _text;


        public EditViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        public IMvxCommand SubmitRecordCommand => new MvxCommand(SubmitRecordExecute);
        public IMvxCommand BackRecordCommand => new MvxCommand(BackRecordExecute);


        public string Text
        {
            get => _text;
            set
            {
                SetProperty(ref _text, value);
            }
        }   


        private void SubmitRecordExecute()
        {
            _navigationService.Close(this, new Result(Text, false));
        }


        public void BackRecordExecute()
        {
            _navigationService.Close(this, new Result());
        }


        public override void Prepare(Parameter parameter)
        {
            Text = parameter.Task.Text;
        }


        public class Parameter
        {
            public IToDoTask Task {get; private set; }


            public Parameter(IToDoTask task = null)
            {
                Task = task;
            }
        }


        public class Result
        {
            public string Text { get; private set; }

            public bool IsRejected { get; private set; }


            public Result(string text = null, bool isrejected = true)
            {
                Text = text;
                IsRejected = isrejected;
            }
        }
    }
}
