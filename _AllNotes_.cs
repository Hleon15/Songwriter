using System;
using System.Collections.Generic;

namespace Songwriter3
{
	public class _AllNotes_
	{
		//FIELDS
		private List<AllNotes_IndividualNote> allNotes = new List<AllNotes_IndividualNote>();

		//PROPERTIES
		public List<AllNotes_IndividualNote> Allnotes
		{
			get
			{
				return allNotes;
			}
		}
		public _AllNotes_ ()
		{
		}
		//METHODS
		public void AddNoteToList(AllNotes_IndividualNote note)
		{
			allNotes.Add(note);
		}
	}
}

