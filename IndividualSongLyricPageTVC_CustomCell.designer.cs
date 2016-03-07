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
	[Register ("IndividualSongLyricPageTVC_CustomCell")]
	partial class IndividualSongLyricPageTVC_CustomCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LyricNameL { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView LyricsTV { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LyricNameL != null) {
				LyricNameL.Dispose ();
				LyricNameL = null;
			}
			if (LyricsTV != null) {
				LyricsTV.Dispose ();
				LyricsTV = null;
			}
		}
	}
}
