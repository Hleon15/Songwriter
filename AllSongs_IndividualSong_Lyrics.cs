using System;

namespace Songwriter3
{
	public class AllSongs_IndividualSong_Lyrics
	{
		//FIELDS
		private string sectionName;
		private string sectionLyrics;
		private string sectionNotes;
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
		public string SectionNotes
		{
			get
			{
				return sectionNotes;
			}
			set
			{
				sectionNotes = value;
			}
		}
		//CONSTRUCTOR
		public AllSongs_IndividualSong_Lyrics ()
		{
		}
	}
}

