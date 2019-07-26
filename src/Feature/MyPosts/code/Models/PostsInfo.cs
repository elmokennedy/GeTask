using System.Collections.Generic;
using Sitecore.Data.Items;

namespace Feature.MyPosts.Models
{
    public class PostsInfo
    {
        public List<Post> Posts { get; set; }

        public Item PostsInfoItem { get; set; }

        public int LoadMoreItemsCount { get; set; }

        public string SourceLink { get; set; }
    }
}