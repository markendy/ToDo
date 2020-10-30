using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using ToDo.Core;
using ToDo.Core.Services;
using ToDo.Core.Services.Interfaces;


namespace ToDo.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override IMvxApplication CreateApp()
        {
            RegisterDependencies();

            return new Core.App();
        }


        private void RegisterDependencies()
        {
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton
                <ITaskListTableManager, TaskListTableManager>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton
                <IFactory, TaskFactory>();
        }
    }
}
