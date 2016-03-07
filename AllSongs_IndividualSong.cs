using System;
using System.Collections.Generic;

namespace Songwriter3
{
	public class AllSongs_IndividualSong
	{
		//FIELDS
		private string songName;
		private DateTime songCreationTime;
		private List<AllSongs_IndividualSong_Lyrics> lyricSections = new List<AllSongs_IndividualSong_Lyrics>();

		//PROPERTIES
		public string SongName
		{
			get
			{
				return songName;
			}
		}
		public DateTime SongCreationTime
		{
			get
			{
				return songCreationTime;
			}
		}
		public List<AllSongs_IndividualSong_Lyrics> LyricSections
		{
			get
			{
				return lyricSections;
			}
		}
		//CONSTRUCTOR
		public AllSongs_IndividualSong (string songName)
		{
			this.songName = songName;
			songCreationTime = DateTime.Now;
		}
	}
}

