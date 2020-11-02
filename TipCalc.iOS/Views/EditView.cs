using ToDo.Core.ViewModel;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views.Gestures;


namespace ToDo.iOS.View
{
    public partial class EditView : MvxViewController
    {
        public EditView() : base("EditView", null)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<EditView, EditViewModel>();
            set.Bind(SubmitButton.Tap()).For(x=>x.Command).To(vm => vm.SubmitRecordCommand);
            set.Bind(BackButton.Tap()).For(x => x.Command).To(vm => vm.BackRecordCommand);
            set.Bind(TextView).For(v=>v.Text).To(vm => vm.Text).TwoWay();
            set.Apply();
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

