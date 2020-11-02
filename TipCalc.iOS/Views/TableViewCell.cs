using System;
using Foundation;
using MvvmCross.Platforms.Ios.Binding.Views.Gestures;
using ToDo.Core.Model;
using UIKit;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Binding.BindingContext;
using ToDo.Core.Primitives;
using System.Drawing;

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


        public ToDoTaskState State
        {
            private get => throw new System.NotImplementedException();
            set
            {
                switch (value)
                {
                    case ToDoTaskState.NotPerformed:
                        ContentView.BackgroundColor = UIColor.White;
                        break;
                    case ToDoTaskState.Performed:
                        ContentView.BackgroundColor = UIColor.Green;
                        break;
                }
            }
        }


        protected TableViewCell(IntPtr handle) : base(handle)
        {
            InitializeBinding();
        }


        private void CompleteUI()
        {
            //UI if needed
        }



        private void InitializeBinding()
        {
            this.DelayBind(delegate
            {
                var set = this.CreateBindingSet<TableViewCell, ToDoTaskModel>();

                set.Bind(this).For(x => x.State).To(vm => vm.State).OneWay();

                set.Bind(OkButton.Tap()).For(x => x.Command).To(vm => vm.OkRecordCommand);
                set.Bind(EditButton.Tap()).For(x => x.Command).To(vm => vm.EditRecordCommand);
                set.Bind(DeleteButton.Tap()).For(x => x.Command).To(vm => vm.DeleteRecordCommand);

                set.Bind(Text).For(x => x.Text).To(vm => vm.Text);

                set.Apply();
            });
        }
    }
}
