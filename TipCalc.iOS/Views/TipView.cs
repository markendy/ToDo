using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views.Gestures;
using MvvmCross.Platforms.Ios.Views;
using ToDo.Core.ViewModel;
using UIKit;
using TipCalc.UI.iOS.Views;

namespace TipCalc.iOS
{
    public partial class TipView : MvxViewController<TipViewModel>
    {
        public TipView() : base(nameof(TipView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var source = new MainViewDataSource(TableView);

            var set = this.CreateBindingSet<TipView, TipViewModel>();      
            set.Bind(source).For(v=> v.ItemsSource).To(vm => vm.TaskList);

            set.Bind(AddButton.Tap()).For(v=> v.Command).To(vm => vm.AddRecordCommand);
            set.Apply();

            TableView.Source = source;
            TableView.ReloadData();
           

        }
    }
}