using System;

namespace LinqPost3
{
	public class Lecture
	{
		public int Id { get; set; }

		public int TeacherId { get; set; }

        public string Level { get; set; }

		public string Name { get; set; }
		
		public Teacher Teacher { get; set; }
	}
}

