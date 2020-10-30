using System;
using Foundation;
using MvvmCross.Platforms.Ios.Binding.Views.Gestures;
using ToDo.Core.Model;
using UIKit;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Binding.BindingContext;


namespace ToDo.iOS.View
{
    public partial class TableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(TableViewCell));
        public static readonly UINib Nib;

        
        static TableViewCell()
        {
            Nib = UINib.FromName(nameof(TableViewCell), NSBundle.MainBundle);
        }


        public bool IsPrepared { get; private set; }


        protected TableViewCell(IntPtr handle) : base(handle)
        {
            InitializeBinding();
        }


        public void Prepare()
        {
            if (IsPrepared)
                return;

            IsPrepared = true;
            CompleteUI();
        }


        private void CompleteUI()
        {
            //UI if needed
        }



        private void InitializeBinding()
        {
            var set = this.CreateBindingSet<TableViewCell, ToDoTaskModel>();

            set.Bind(OkButton.Tap()).For(x => x.Command).To(vm => vm.OkRecordCommand); // тут вылетает
            set.Bind(EditButton.Tap()).For(x => x.Command).To(vm => vm.EditRecordCommand);
            set.Bind(DeleteButton.Tap()).For(x => x.Command).To(vm => vm.DeleteRecordCommand);

            set.Bind(Text).For(x=>x.Text).To(vm => vm.Text);

            set.Apply();
        }
    }
}
