using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
//This class gives access to the custom cell UI elements. 
namespace Songwriter3
{
	partial class IndividualSongLyricPageTVC_CustomCell : UITableViewCell
	{
		//FIELDS
		UITableViewController tableView;
		AllSongs_IndividualSong_Lyrics lyrics;
		//PROPERTIES

		//CONSTRUCTOR
		public IndividualSongLyricPageTVC_CustomCell (IntPtr handle) : base (handle)
		{
		}
		//METHODS
		public void SetCellElements(AllSongs_IndividualSong_Lyrics song)
		{
			lyrics = song;
			LyricNameL.Text = song.SectionName;
			LyricsTV.Text = song.SectionLyrics;
		}
		//
		public void SetTableview(UITableViewController tableView)
		{
			if(this.tableView == null)
			{
				this.tableView = tableView;
				LyricsTV.Changed += LyricsTV_Changed; //.changed menas if text view ever changes, it calls the method on the right of the +=.
			}

		}
		//
		void LyricsTV_Changed (object sender, EventArgs e)
		{
			lyrics.SectionLyrics = LyricsTV.Text;//save lyrics into SectionLyrics
			tableView.TableView.BeginUpdates();
			tableView.TableView.EndUpdates();
		}

		partial void NoteButton_TouchUpInside (UIButton sender)
		{
			IndividualSongLyricPage_NotePageVC sectionNotes = UIStoryboard.FromName("Main",null).InstantiateViewController("IndivdualSongLyricPage_NotePageSBID") as IndividualSongLyricPage_NotePageVC;
			sectionNotes.SetSection(lyrics);
			tableView.NavigationController.ShowViewController(sectionNotes,this);

		}

        partial void RecordingButton_TouchUpInside(UIButton sender)
        {
            RecordingsTableViewController recordings = UIStoryboard.FromName("Main", null).InstantiateViewController("RecordingsTableViewController") as RecordingsTableViewController;
            recordings.SetSection(lyrics);
            tableView.NavigationController.ShowViewController(recordings, this);
        }
    }
}
