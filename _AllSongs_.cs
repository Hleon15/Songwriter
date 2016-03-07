using System;
using System.Collections.Generic;

namespace Songwriter3
{
	public class _AllSongs_
	{
		//FIELDS
		private List<AllSongs_IndividualSong> allSongs = new List<AllSongs_IndividualSong>();

		//PROPERTIES
		public List<AllSongs_IndividualSong> AllSongs
		{
			get
			{
				return allSongs;
			}
		}

		//CONSTRUCTOR
		public _AllSongs_ ()
		{
		}
		//METHODS
		public void AddSongToList(AllSongs_IndividualSong song)
		{
			allSongs.Add(song);
		}
	}
}

