using Songwriter3.Classes;
using System;
using System.Collections.Generic;

namespace Songwriter3
{
	public class AllSongs_IndividualSong_Lyrics
	{
		//FIELDS
		private string sectionName;
		private string sectionLyrics;
		private string sectionNotes;
        private List<Recording> recordings = new List<Recording>();

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
        public List<Recording> Recordings
        {
            get
            {
                return recordings;
            }
        }
		//CONSTRUCTOR
		public AllSongs_IndividualSong_Lyrics ()
		{
		}
	}
}

