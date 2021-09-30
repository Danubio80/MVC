using System;
using System.Collections.Generic;

namespace LinqPost3
{
	public class Teacher
	{
		public int Id { get; set; }

		public int Age { get; set; }

		public string GivenName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }
        public ICollection<Lecture> Lectures { get; set; }

    }
    public class Blog 
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}

