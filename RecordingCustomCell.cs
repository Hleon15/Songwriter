using Foundation;
using Songwriter3.Classes;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class RecordingCustomCell : UITableViewCell
	{
        private Recording _recording;

        public RecordingCustomCell (IntPtr handle) : base (handle)
		{
		}
        public void SetRecording(Recording recording)
        {
            _recording = recording;
            SongNameLabel.Text = _recording.FileName;
        }
	}
}
