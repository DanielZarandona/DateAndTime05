using System;
using System.Globalization;
using Foundation;
using UIKit;

namespace DateAndTime05
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            BtnDateTime.TouchUpInside += BtnDateTime_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        #region User Interactions
        void BtnDateTime_TouchUpInside(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;
            LblDate.Text = currentTime.ToShortDateString();
            LblTime.Text = currentTime.ToShortTimeString();
        }

        partial void BtnNSDate_TouchUpInside(Foundation.NSObject sender)
        {
            var currentTime = new NSDate();
            NSDateFormatter dateFormatter = new NSDateFormatter();
            dateFormatter.DateFormat = "dd 'de' MMMM 'de' yyyy";
            NSDateFormatter timeFormatter = new NSDateFormatter();
            timeFormatter.DateFormat = "h:m:s a";
            NSLocale locale = new NSLocale("es_MX");
            dateFormatter.Locale = locale;
            timeFormatter.Locale = locale;
            LblDate.Text = dateFormatter.ToString(currentTime);
            LblTime.Text = timeFormatter.ToString(currentTime);

        }
        #endregion
    }
}
