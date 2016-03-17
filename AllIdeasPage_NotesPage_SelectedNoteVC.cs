using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class AllIdeasPage_NotesPage_SelectedNoteVC : UIViewController
	{
		//FIELDS
		private AllNotes_IndividualNote selectedNote;

		//CONSTRUCTOR
		public AllIdeasPage_NotesPage_SelectedNoteVC (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NotePageTextView.TextContainerInset = UIEdgeInsets.Zero;
			NotePageTextView.ContentInset = new UIEdgeInsets(-15, 0, 0, 0);
			NotePageTextView.Text = selectedNote.Note; //loading from SectionNotes to textview.
		}
		//Allows us to get access to a section from the IndivdualSongLyricPageTVC. We store the reference in a local variable.
		public void SetNote(AllNotes_IndividualNote selectedNote)
		{
			this.selectedNote = selectedNote;
		}
		//When we hit the back button, save whatever is in the text view into the section notes.
		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			selectedNote.Note = NotePageTextView.Text; // saving from text view to SectionNotes variable.
		}
	}
}
