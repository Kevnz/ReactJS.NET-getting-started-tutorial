using ReactDemo.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> _comments;

        static HomeController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Author = "Kevin Isom",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Author = "A Person",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Author = "Someone Else",
                    Text = "This is *another* comment"
                },
            };
        }

        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
        {
            _comments.Add(comment);
            return Content("Success :)");
        }

        public ActionResult Comments()
        {
            return Json(_comments, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View(_comments);
        }

    }
}
