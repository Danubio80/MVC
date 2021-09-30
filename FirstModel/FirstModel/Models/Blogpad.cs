using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstModel.Models
{
    public class Blogpad
    {
        public int BlogId { get; set; }

        public string Url { get; set; }





    }

    public class Blog : Blogpad

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

