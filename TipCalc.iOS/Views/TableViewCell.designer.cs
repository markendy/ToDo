// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ToDo.iOS.View
{
    [Register ("TableViewCell")]
    partial class TableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EditButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OkButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Text { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DeleteButton != null) {
                DeleteButton.Dispose ();
                DeleteButton = null;
            }

            if (EditButton != null) {
                EditButton.Dispose ();
                EditButton = null;
            }

            if (OkButton != null) {
                OkButton.Dispose ();
                OkButton = null;
            }

            if (Text != null) {
                Text.Dispose ();
                Text = null;
            }
        }
    }
}