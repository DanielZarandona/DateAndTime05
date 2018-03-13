// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DateAndTime05
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton BtnDateTime { get; set; }

        [Outlet]
        UIKit.UIButton BtnNSDate { get; set; }

        [Outlet]
        UIKit.UILabel LblDate { get; set; }

        [Outlet]
        UIKit.UILabel LblTime { get; set; }

        [Action ("BtnNSDate_TouchUpInside:")]
        partial void BtnNSDate_TouchUpInside (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (LblDate != null) {
                LblDate.Dispose ();
                LblDate = null;
            }

            if (LblTime != null) {
                LblTime.Dispose ();
                LblTime = null;
            }

            if (BtnNSDate != null) {
                BtnNSDate.Dispose ();
                BtnNSDate = null;
            }

            if (BtnDateTime != null) {
                BtnDateTime.Dispose ();
                BtnDateTime = null;
            }
        }
    }
}
