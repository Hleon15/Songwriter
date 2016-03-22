using Foundation;
using Songwriter3.Classes;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Songwriter3
{
	partial class RecordingsTableViewController : UITableViewController
	{
        private AllSongs_IndividualSong_Lyrics _section;
        private AudioPlayer _audioPlayer;
        private bool justCreatedPage = false;
        public RecordingsTableViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView.RowHeight = UITableView.AutomaticDimension;
            TableView.EstimatedRowHeight = 60;
            this.NavigationItem.SetRightBarButtonItem(
            new UIBarButtonItem(UIBarButtonSystemItem.Add, (sender, args) => {
                RecordingViewController controller = Storyboard.InstantiateViewController("RecordingViewController") as RecordingViewController;
                controller.SetSection(_section);
                NavigationController.ShowViewController(controller, this);
            })
            , true);

            _audioPlayer = new AudioPlayer();
            justCreatedPage = true;
        }
        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            _audioPlayer.DeactivateAudioSession();
        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            if (justCreatedPage)
            {
                justCreatedPage = false;
            }
            else
            {
                _audioPlayer.ReactivateAudioSession();
            }
            TableView.ReloadData();
        }
        public void SetSection(AllSongs_IndividualSong_Lyrics section)
        {
            _section = section;
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return _section.Recordings.Count;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            RecordingCustomCell cell = tableView.DequeueReusableCell("RecordingCellID") as RecordingCustomCell;
            cell.SetRecording(_section.Recordings[indexPath.Row]);
            return cell;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            _audioPlayer.PlaySound(_section.Recordings[indexPath.Row].FilePath);
        }
    }
}
