using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class AllIdeasPageTVC : UITableViewController
	{
		//FIELDS
		public static _AllNotes_ allNotes = new _AllNotes_();
		//CONSTRUCTOR
		public AllIdeasPageTVC (IntPtr handle) : base (handle)
		{
		}
		//METHODS
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			TableView.TableFooterView = new UIView(); //takes away lines under 2 cells.
		}
	}
}
