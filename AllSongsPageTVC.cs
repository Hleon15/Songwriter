using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class AllSongsPageTVC : UITableViewController
	{
		//FIELDS
		private _AllSongs_ allSongs = new _AllSongs_();
		//PROPERTIES
		//CONSTRUCTOR
		public AllSongsPageTVC (IntPtr handle) : base (handle)
		{
		}
		//METHODS
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.NavigationItem.SetRightBarButtonItem(
				new UIBarButtonItem(UIBarButtonSystemItem.Add, (sender,args) => {
					// button was clicked
					//Create Alert
					var textInputAlertController = UIAlertController.Create("Add Song", null, UIAlertControllerStyle.Alert);

					//Add Text Input
					textInputAlertController.AddTextField(textField => {
					});

					//Add Actions
					var cancelAction = UIAlertAction.Create ("Cancel", UIAlertActionStyle.Default, alertAction => Console.WriteLine ("Cancel was Pressed"));
					var okayAction = UIAlertAction.Create ("Add", UIAlertActionStyle.Cancel, alertAction => 
						{
							AllSongs_IndividualSong song = new AllSongs_IndividualSong(textInputAlertController.TextFields[0].Text.ToString());
							allSongs.AddSongToList(song);
							TableView.ReloadData();
						});

					textInputAlertController.AddAction(cancelAction);
					textInputAlertController.AddAction(okayAction);

					//Present Alert
					PresentViewController(textInputAlertController, true, null);
				})
				, true);
		}
		//Amount of rows to be created
		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return allSongs.AllSongs.Count;
		}

		// Defining cell
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("AllSongsPageCID");
			cell.TextLabel.Text = allSongs.AllSongs[indexPath.Row].SongName;
			cell.DetailTextLabel.Text = allSongs.AllSongs[indexPath.Row].SongCreationTime.ToShortDateString();
			return cell;
		}
		//Gets called when a row is selected
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			IndividualSongLyricPageTVC lyricPage = Storyboard.InstantiateViewController("IndividualSongLyricPageSBID") as IndividualSongLyricPageTVC; //creates the page with the corrosponding storyboard ID when clicked.
			lyricPage.SelectedSong = allSongs.AllSongs[indexPath.Row]; //passing in the selected song into the newly created page using the property to store the reference into a local variable.
			NavigationController.ShowViewController(lyricPage,this); //this puts the page onto the screen. This is for who sends you to the next page.
		}

	}
}
