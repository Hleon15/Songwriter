using System;

namespace Songwriter3
{
	public class AllNotes_IndividualNote
	{
		//FIELDS
		private string noteName;
		private DateTime noteCreationTime;
		private string note;

		//PROPERTIES
		public string NoteName
		{
			get
			{
				return noteName;
			}
			set
			{
				noteName = value;
			}
		}
		public DateTime NoteCreationTime
		{
			get
			{
				return noteCreationTime;
			}
		}
		public string Note
		{
			get
			{
				return note;
			}
			set
			{
				note = value;
			}
		}
		//CONSTRUCTOR
		public AllNotes_IndividualNote (string noteName)
		{
			this.noteName = noteName;
			noteCreationTime = DateTime.Now;
		}
	}
}

