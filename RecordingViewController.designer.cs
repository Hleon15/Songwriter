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
	[Register ("RecordingViewController")]
	partial class RecordingViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton RecordButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton StopButton { get; set; }

		[Action ("RecordButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void RecordButton_TouchUpInside (UIButton sender);

		[Action ("StopButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void StopButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (RecordButton != null) {
				RecordButton.Dispose ();
				RecordButton = null;
			}
			if (StopButton != null) {
				StopButton.Dispose ();
				StopButton = null;
			}
		}
	}
}
