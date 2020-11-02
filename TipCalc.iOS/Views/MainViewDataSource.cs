using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using Foundation;
using MvvmCross.Binding.Extensions;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.WeakSubscription;
using ToDo.iOS.View;
using UIKit;

namespace TipCalc.UI.iOS.Views
{
    public class MainViewDataSource : MvxTableViewSource
    {


        public MainViewDataSource(UITableView tableView) : base(tableView)
        {
            tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            tableView.SeparatorInset = UIEdgeInsets.Zero;
            tableView.LayoutMargins = UIEdgeInsets.Zero;
            tableView.ContentInset = UIEdgeInsets.Zero;
            tableView.RegisterNibForCellReuse(TableViewCell.Nib, nameof(TableViewCell));
        }

 
        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = ((TableViewCell)tableView.DequeueReusableCell(nameof(TableViewCell), indexPath));
            return cell;
        }
    }


}
