using GamesStreamBlog.Models;
using GamesStreamBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesStreamBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Typically we retrieve data from the database (wherever)
            // And inject the retrieved data into ViewModel->View
            // Today we'll fake the data that than use the database

            Blog otc = new Blog { BlogTitle = "Ode To Code", BlogAuthor = "Scott Allen" };
            Blog hm = new Blog { BlogTitle = "Hanselman Minutes",
                BlogAuthor = "Scott Hanselman",
                BlogPosts = new List<Post> {
                    new Post{PostTitle= "ef 6 launched", PostContent = "EF6 is wonderful"},
                    new Post {PostTitle = "Silverlight RIP", PostContent = "Microsoft finally admit Silverlight is dead" }
                }
        };

            //Now populate the viewmodel with the data (above) from the database

            BlogViewModel bvm = new BlogViewModel() {TheBlogs=new List<Blog> { otc, hm }};
            bvm.NumberOfBlogs = bvm.TheBlogs.Count;

            return View(bvm);
        }
        public ActionResult Details(string id)
        {
           

            Blog otc = new Blog { BlogTitle = "Ode To Code", BlogAuthor = "Scott Allen" };
            Blog hm = new Blog
            {
                BlogTitle = "Hanselman Minutes",
                BlogAuthor = "Scott Hanselman",
                BlogPosts = new List<Post> {
                    new Post{PostTitle= "ef 6 launched", PostContent = "EF6 is wonderful"},
                    new Post {PostTitle = "Silverlight RIP", PostContent = "Microsoft finally admit Silverlight is dead" }
                }
            };

            //Now populate the viewmodel with the data (above) from the database

            BlogViewModel bvm = new BlogViewModel() { TheBlogs = new List<Blog> { otc, hm } };
            bvm.NumberOfBlogs = bvm.TheBlogs.Count;
            foreach (Blog blg in bvm.TheBlogs)
            {
                if (blg.BlogTitle == id) return View(blg);
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}