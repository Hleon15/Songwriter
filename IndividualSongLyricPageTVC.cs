using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class IndividualSongLyricPageTVC : UITableViewController
	{
		//FIELDS 
		//This is going to hold the selected song from the prior page's memory location (reference)
		private AllSongs_IndividualSong selectedSong;
		//PROPERTIES
		public AllSongs_IndividualSong SelectedSong
		{
			get
			{
				return selectedSong;
			}
			set
			{
				selectedSong = value;
			}
		}

		//CONSTRUCTOR
		public IndividualSongLyricPageTVC (IntPtr handle) : base (handle)
		{
		}
		//METHODS
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			TableView.RowHeight = UITableView.AutomaticDimension; //make the height automatically based of content
			TableView.EstimatedRowHeight = 150; 
			this.NavigationItem.SetRightBarButtonItem(
				new UIBarButtonItem(UIBarButtonSystemItem.Add, (sender,args) => {
					// button was clicked
					// Create a new Alert Controller
					UIAlertController actionSheetAlert = UIAlertController.Create("Add", null, UIAlertControllerStyle.ActionSheet);

					// Add Actions
					actionSheetAlert.AddAction(UIAlertAction.Create("Verse",UIAlertActionStyle.Default, (action) => createNewSection("Verse")));

					actionSheetAlert.AddAction(UIAlertAction.Create("Pre-Chorus",UIAlertActionStyle.Default, (action) => createNewSection("Pre-Chorus")));

					actionSheetAlert.AddAction(UIAlertAction.Create("Chorus",UIAlertActionStyle.Default, (action) => createNewSection("Chorus")));

					actionSheetAlert.AddAction(UIAlertAction.Create("Bridge",UIAlertActionStyle.Default, (action) => createNewSection("Bridge")));
					actionSheetAlert.AddAction(UIAlertAction.Create("Cancel",UIAlertActionStyle.Cancel, (action) => {}));

					/*// Required for iPad - You must specify a source for the Action Sheet since it is
					// displayed as a popover
					UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
					if (presentationPopover!=null) {
						presentationPopover.SourceView = this.View;
						presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;
					}*/

					// Display the alert
					this.PresentViewController(actionSheetAlert,true,null);
				})
				, true);
		}
		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return selectedSong.LyricSections.Count;
		}

		// Defining cell
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			IndividualSongLyricPageTVC_CustomCell cell = tableView.DequeueReusableCell("IndividualSongLyricPageCID") as IndividualSongLyricPageTVC_CustomCell;
			cell.SetCellElements(selectedSong.LyricSections[indexPath.Row]);
			cell.SetTableview(TableView);
			return cell;
		}
		private void createNewSection(string section)
		{
			AllSongs_IndividualSong_Lyrics lyricSection = new AllSongs_IndividualSong_Lyrics();
			lyricSection.SectionName = section;
			lyricSection.SectionLyrics = "";
			selectedSong.LyricSections.Add(lyricSection);
			TableView.ReloadData();
		}
	}
}
