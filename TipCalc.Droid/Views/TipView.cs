using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using ToDo.Core.ViewModel;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding;
using Android.Widget;
using MvvmCross.Platforms.Android.Binding.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using Android.Content;
using Android.Views;


namespace ToDo.Droid.Views
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class TipView : MvxActivity<TipViewModel>
    {
        private MvxListView _listView;
        private Button _buttonAdd;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(TipCalc.UI.Droid.Resource.Layout.MainView);

            DefineUI();            
            ApplyBindings();         
        }


        private void DefineUI()
        {
            _listView = FindViewById<MvxListView>(TipCalc.UI.Droid.Resource.Id.MvxListView);
            _buttonAdd = FindViewById<Button>(TipCalc.UI.Droid.Resource.Id.AddButton);

            _listView.Adapter = new CustomAdapter(this, (IMvxAndroidBindingContext)BindingContext);
            _listView.ItemTemplateId = TipCalc.UI.Droid.Resource.Layout.TaskOne;
        }


        private void ApplyBindings()
        {
            var set = this.CreateBindingSet<TipView, TipViewModel>();
            set.Bind(_buttonAdd).For(x => x.BindClick()).To(vm => vm.AddRecordCommand);
            set.Bind(_listView).For(t => t.ItemsSource).To(vm => vm.TaskList);
            set.Apply();
        }


        public class CustomAdapter : MvxAdapter
        {
            public CustomAdapter(Context context, IMvxAndroidBindingContext bindingContext)
                : base(context, bindingContext)
            {
            }

            protected override IMvxListItemView CreateBindableView(object dataContext, ViewGroup parent, int templateId)
            {
                return new ToDoCellView(Context, BindingContext.LayoutInflaterHolder,
                    dataContext, parent, templateId);
            }
        }
    }
}