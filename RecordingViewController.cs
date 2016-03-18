using Foundation;
using Songwriter3.Classes;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class RecordingViewController : UIViewController
	{
        private AllSongs_IndividualSong_Lyrics _section;
        private AudioRecorder _recorder;

		public RecordingViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _recorder = new AudioRecorder(_section.SectionName);
        }

        public void SetSection(AllSongs_IndividualSong_Lyrics section)
        {
            _section = section;
        }

        partial void RecordButton_TouchUpInside(UIButton sender)
        {
            _recorder.StartRecording();
        }

        partial void StopButton_TouchUpInside(UIButton sender)
        {
            _section.Recordings.Add(_recorder.StopRecording());
        }
    }
}
