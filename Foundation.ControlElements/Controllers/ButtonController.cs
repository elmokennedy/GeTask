using System.Web.Mvc;
using Sitecore;
using Sitecore.Mvc.Presentation;
using Foundation.ControlElements.Models;

namespace Foundation.ControlElements.Controllers
{
    public class ButtonController : Controller
    {
        public ActionResult LoadMoreButton()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Context.Database.GetItem(dataSourceId);

            var itemsToLoad = int.Parse(dataSource.Fields["LoadMoreItemsCount"].Value);

            var buttonCaption = new LoadMoreButton
            {
                LoadMoreButtonCaption = dataSource,
                LoadMoreItemsCount = itemsToLoad
            };

            return View(buttonCaption);
        }
    }
}