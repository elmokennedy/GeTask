using System.Web.Mvc;
using Feature.MyPosts.Models;
using Sitecore.Mvc.Presentation;
using Feature.MyPosts.Services.Interfaces;
using System.Collections.Generic;

namespace Feature.MyPosts.Controllers
{
    public class MyPostsController : Controller
    {
        private IPostService _postService;

        public MyPostsController(IPostService postService)
        {
            this._postService = postService;
        }

        public ActionResult Posts()
        {
            var dataSource = RenderingContext.CurrentOrNull.Rendering.Item;
            var renderingParameters = RenderingContext.Current.Rendering.Parameters;

            var posts = new List<Post>();
            if (int.TryParse(renderingParameters["ItemsCount"], out var initialPostsCount))
            {
                posts = this._postService.GetPosts(renderingParameters["SourceLink"], initialPostsCount);
            }

            int.TryParse(renderingParameters["LoadMoreItemsCount"], out var loadMoreCount);

            var postsInfo = new PostsInfo
            {
                Posts = posts,
                PostsInfoItem = dataSource,
                LoadMoreItemsCount = loadMoreCount,
                SourceLink = renderingParameters["SourceLink"]
            };

            return View(postsInfo);
        }
    }
}