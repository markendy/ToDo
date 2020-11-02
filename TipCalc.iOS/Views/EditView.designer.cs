using Foundation;
using System.CodeDom.Compiler;
using UIKit;


namespace ToDo.iOS.View
{
    [Register("EditView")]
    public partial class EditView
    {
        [Outlet]
        [GeneratedCode("iOS Desiner", "1.0")]
        UITextView TextView { get; set; }
        [Outlet]
        [GeneratedCode("iOS Desiner", "1.0")]
        UIButton SubmitButton { get; set; }
        [Outlet]
        [GeneratedCode("iOS Desiner", "1.0")]
        UIButton BackButton { get; set; }


        void ReleaseDesignerOutlets()
        {
            if (TextView != null)
            {
                TextView.Dispose();
                TextView = null;
            }
            if (SubmitButton != null)
            {
                SubmitButton.Dispose();
                SubmitButton = null;
            }
            if (BackButton != null)
            {
                BackButton.Dispose();
                BackButton = null;
            }
        }
    }
}
