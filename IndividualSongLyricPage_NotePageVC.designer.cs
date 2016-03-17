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

namespace Songwriter3
{
	[Register ("IndividualSongLyricPage_NotePageVC")]
	partial class IndividualSongLyricPage_NotePageVC
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView NotePageTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (NotePageTextView != null) {
				NotePageTextView.Dispose ();
				NotePageTextView = null;
			}
		}
	}
}
