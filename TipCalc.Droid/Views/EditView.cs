using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using ToDo.Core.ViewModel;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding;
using Android.Widget;


namespace ToDo.Droid.Views
{
    [Activity(Label = "@string/app_name")]
    public class EditView : MvxActivity<EditViewModel>
    {
        private EditText _editText;
        private Button _submitButton;
        private Button _backButton;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(TipCalc.UI.Droid.Resource.Layout.EditView);
            DefineUI();
            ApplyBindings();
        }


        private void DefineUI()
        {
            _editText = FindViewById<EditText>(TipCalc.UI.Droid.Resource.Id.EditText);
            _submitButton = FindViewById<Button>(TipCalc.UI.Droid.Resource.Id.SubmitButton);
            _backButton = FindViewById<Button>(TipCalc.UI.Droid.Resource.Id.BackButton);
        }


        private void ApplyBindings()
        {
            var set = this.CreateBindingSet<EditView, EditViewModel>();
            set.Bind(_backButton).For(x => x.BindClick()).To(vm => vm.BackRecordCommand);
            set.Bind(_submitButton).For(x => x.BindClick()).To(vm => vm.SubmitRecordCommand);
            set.Bind(_editText).For(x => x.Text).To(vm => vm.Text).TwoWay();
            set.Apply();
        }
    }
}