using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class IndividualSongLyricPage_NotePageVC : UIViewController
	{
		//FIELDS
		private AllSongs_IndividualSong_Lyrics section;
		//CONSTRUCTOR
		public IndividualSongLyricPage_NotePageVC (IntPtr handle) : base (handle)
		{
		}
		//METHODS
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NotePageTextView.TextContainerInset = UIEdgeInsets.Zero;
			NotePageTextView.ContentInset = new UIEdgeInsets(-15, 0, 0, 0);
			NotePageTextView.Text = section.SectionNotes; //loading from SectionNotes to textview.
		}
		//Allows us to get access to a section from the IndivdualSongLyricPageTVC. We store the reference in a local variable.
		public void SetSection(AllSongs_IndividualSong_Lyrics section)
		{
			this.section = section;
		}
		//When we hit the back button, save whatever is in the text view into the section notes.
		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			section.SectionNotes = NotePageTextView.Text; // saving from text view to SectionNotes variable.
		}
	}
}
