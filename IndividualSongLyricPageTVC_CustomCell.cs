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
		UITableView tableView;
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
		public void SetTableview(UITableView tableView)
		{
			if(this.tableView == null)
			{
				this.tableView = tableView;
				LyricsTV.Changed += LyricsTV_Changed;
			}

		}

		void LyricsTV_Changed (object sender, EventArgs e)
		{
			lyrics.SectionLyrics = LyricsTV.Text;
			tableView.BeginUpdates();
			tableView.EndUpdates();
		}
	}
}
