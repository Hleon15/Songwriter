using System;

namespace Songwriter3
{
	public class AllSongs_IndividualSong_Lyrics
	{
		//FIELDS
		private string sectionName;
		private string sectionLyrics;
		//PROPERTIES
		public string SectionName
		{
			get
			{
				return sectionName;
			}
			set
			{
				sectionName = value;
			}
		}
		public string SectionLyrics
		{
			get
			{
				return sectionLyrics;
			}
			set
			{
				sectionLyrics = value;
			}
		}
		//CONSTRUCTOR
		public AllSongs_IndividualSong_Lyrics ()
		{
		}
	}
}

