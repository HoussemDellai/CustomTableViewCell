// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CustomTableApp3
{
    [Register ("EmployeeTableCell")]
    partial class EmployeeTableCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DepartmentLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DescriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FullnameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DepartmentLabel != null) {
                DepartmentLabel.Dispose ();
                DepartmentLabel = null;
            }

            if (DescriptionLabel != null) {
                DescriptionLabel.Dispose ();
                DescriptionLabel = null;
            }

            if (FullnameLabel != null) {
                FullnameLabel.Dispose ();
                FullnameLabel = null;
            }
        }
    }
}