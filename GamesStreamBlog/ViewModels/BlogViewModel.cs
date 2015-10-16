using GamesStreamBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesStreamBlog.ViewModels
{
    //A representation of a particular subset of database
    public class BlogViewModel
    {
        public int NumberOfBlogs { get; set; }
        public List<Blog> TheBlogs { get; set; }
    }
}