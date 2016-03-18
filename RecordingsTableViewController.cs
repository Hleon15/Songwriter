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
        }
        public void SetSection(AllSongs_IndividualSong_Lyrics section)
        {
            _section = section;
        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            TableView.ReloadData();
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
            AudioPlayer player = new AudioPlayer();
            player.PlaySound(_section.Recordings[indexPath.Row].FilePath);
        }
    }
}
