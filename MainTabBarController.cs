using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class MainTabBarController : UITabBarController
	{
		public MainTabBarController (IntPtr handle) : base (handle)
		{
            ShouldSelectViewController = (tabController, controller) =>
            {
                if (controller is QuickActionViewControllerPlaceHolder)
                {
                    // button was clicked
                    // Create a new Alert Controller
                    UIAlertController actionSheetAlert = UIAlertController.Create("Add", null, UIAlertControllerStyle.ActionSheet);

                    // Add Actions
                    actionSheetAlert.AddAction(UIAlertAction.Create("Verse", UIAlertActionStyle.Default, (action) => { }));
                    actionSheetAlert.AddAction(UIAlertAction.Create("Verse", UIAlertActionStyle.Default, (action) => { }));
                    actionSheetAlert.AddAction(UIAlertAction.Create("Verse", UIAlertActionStyle.Default, (action) => { }));
                    actionSheetAlert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (action) => { }));

                    // Display the alert
                    this.PresentViewController(actionSheetAlert, true, null);

                    return false;
                }
                else
                {
                    return true;
                }
            };
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			TabBar.ClipsToBounds = true;
			Console.WriteLine(TabBar.Frame.Width);
            TabBar.Items[0].ImageInsets = new UIEdgeInsets(7, 0, -7, 0);
            UIImage noteBookImage = UIImage.FromBundle("Notebook.png").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
            TabBar.Items[0].Image = noteBookImage;

            TabBar.Items[1].ImageInsets = new UIEdgeInsets(7, 0, -7, 0);
            UIImage flashOnImage = UIImage.FromBundle("flash-on.png").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
            TabBar.Items[1].Image = flashOnImage;

            TabBar.Items[2].ImageInsets = new UIEdgeInsets(5, 0, -5, 0);
            UIImage lightImage = UIImage.FromBundle("lightbulb.png").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
            TabBar.Items[2].Image = lightImage;
           
        }
    }
}
