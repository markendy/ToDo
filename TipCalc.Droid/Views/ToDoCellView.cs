using Android.Content;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using ToDo.Core.Model;
using MvvmCross.Platforms.Android.Binding;
using ToDo.Core.Primitives;


namespace ToDo.Droid.Views
{
   
    public class ToDoCellView : MvxListItemView
    {
        private TextView _textView;
        private Button _delButton;
        private Button _okButton;
        private Button _editButton;
        private RelativeLayout _backgroundRelativeLayout;


        public ToDoCellView(Context context, IMvxLayoutInflaterHolder layoutInflaterHolder, object dataContext, ViewGroup parent, int templateId)
            : base(context, layoutInflaterHolder, dataContext, parent, templateId)
        {
            DefineUI();
            ApplyBindings();
        }


        public ToDoTaskState State
        {
            private get => throw new System.NotImplementedException();
            set
            {
                switch (value)
                {
                    case ToDoTaskState.NotPerformed:
                        _backgroundRelativeLayout.SetBackgroundColor(
                            new Android.Graphics.Color(255,255,255));
                        break;
                    case ToDoTaskState.Performed:
                        _backgroundRelativeLayout.SetBackgroundColor(
                            new Android.Graphics.Color(100, 200, 100));
                        break;
                }
            }
        }


        private void DefineUI()
        {
            _okButton = Content.FindViewById<Button>(TipCalc.UI.Droid.Resource.Id.OkButton);
            _delButton = Content.FindViewById<Button>(TipCalc.UI.Droid.Resource.Id.DeleteButton);
            _editButton = Content.FindViewById<Button>(TipCalc.UI.Droid.Resource.Id.EditButton);
            _textView = Content.FindViewById<TextView>(TipCalc.UI.Droid.Resource.Id.TextViewCell);
            _backgroundRelativeLayout = Content.FindViewById<RelativeLayout>(TipCalc.UI.Droid.Resource.Id.BackgroundRelativeLayout);
        }


        private void ApplyBindings()
        {
            var set = this.CreateBindingSet<ToDoCellView, ToDoTaskModel>();
            set.Bind(this).For(x => x.State).To(vm => vm.State).OneWay();
            set.Bind(_textView).For(x => x.Text).To(vm => vm.Text);
            set.Bind(_delButton).For(x => x.BindClick()).To(vm => vm.DeleteRecordCommand);
            set.Bind(_editButton).For(x => x.BindClick()).To(vm => vm.EditRecordCommand);
            set.Bind(_okButton).For(x => x.BindClick()).To(vm => vm.OkRecordCommand);
            set.Apply();
        }      
    }
}
