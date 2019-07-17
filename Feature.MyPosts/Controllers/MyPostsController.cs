using System.Web.Mvc;
using Feature.MyPosts.Models;
using Sitecore;
using Sitecore.Mvc.Presentation;
using Feature.MyPosts.Services.Interfaces;

namespace Feature.MyPosts.Controllers
{
    public class MyPostsController : Controller
    {
        private IPostService _postService;

        public MyPostsController(IPostService postService)
        {
            this._postService = postService;
        }

        public ActionResult PostTable()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Context.Database.GetItem(dataSourceId);

            var posts = this._postService.GetPosts(int.Parse(dataSource.Fields["ItemsCount"].Value));

            var postTable = new PostTable
            {
                Posts = posts,
                TableInfoItem = dataSource
            };

            return View(postTable);
        }
    }
}