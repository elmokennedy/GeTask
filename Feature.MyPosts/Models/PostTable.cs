using System.Collections.Generic;
using Sitecore.Data.Items;

namespace Feature.MyPosts.Models
{
    public class PostTable
    {
        public List<Post> Posts { get; set; }

        public Item TableInfoItem { get; set; }
    }
}