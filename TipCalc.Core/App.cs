using MvvmCross.ViewModels;
using ToDo.Core.ViewModel;

namespace ToDo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
             RegisterAppStart<TipViewModel>();
        }
    }
}
