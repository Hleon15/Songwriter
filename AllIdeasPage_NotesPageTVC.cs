using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class AllIdeasPage_NotesPageTVC : UITableViewController
	{
		//FIELDS

		//CONSTRUCTOR
		public AllIdeasPage_NotesPageTVC (IntPtr handle) : base (handle)
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
					var textInputAlertController = UIAlertController.Create("Add Note", null, UIAlertControllerStyle.Alert);

					//Add Text Input
					textInputAlertController.AddTextField(textField => {
					});

					//Add Actions
					var cancelAction = UIAlertAction.Create ("Cancel", UIAlertActionStyle.Default, alertAction => Console.WriteLine ("Cancel was Pressed"));
					var okayAction = UIAlertAction.Create ("Add", UIAlertActionStyle.Cancel, alertAction => 
						{
							AllNotes_IndividualNote note = new AllNotes_IndividualNote(textInputAlertController.TextFields[0].Text.ToString());
							AllIdeasPageTVC.allNotes.AddNoteToList(note);
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
			return AllIdeasPageTVC.allNotes.Allnotes.Count;
		}

		// Defining cell
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("AllIdeasPage_NotesPageCID");
			cell.TextLabel.Text = AllIdeasPageTVC.allNotes.Allnotes[indexPath.Row].NoteName;
			cell.DetailTextLabel.Text = AllIdeasPageTVC.allNotes.Allnotes[indexPath.Row].NoteCreationTime.ToShortDateString();
			return cell;
		}
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			AllIdeasPage_NotesPage_SelectedNoteVC selectedNote = Storyboard.InstantiateViewController("AllIdeasPage_NotesPage_SelectedNoteSBID") as AllIdeasPage_NotesPage_SelectedNoteVC; //Creating the page
			selectedNote.SetNote(AllIdeasPageTVC.allNotes.Allnotes[indexPath.Row]); //calling the method to set the local variable to display the correct information
			NavigationController.ShowViewController(selectedNote,this); //Showing the page, calling from this page.

		}
	

	}
}
