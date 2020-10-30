using MvvmCross;
using ToDo.Core;
//using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.IoC;
using ToDo.Core.Services.Interfaces;
using ToDo.Core.Services;
using MvvmCross.ViewModels;
using MvvmCross.Platforms.Android.Core;

namespace ToDo.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        public Setup()
        {
            
        }


        protected override IMvxApplication CreateApp()
        {
            RegisterDependencies();

            return new App();
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
