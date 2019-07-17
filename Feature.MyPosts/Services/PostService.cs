using System.Collections.Generic;
using Feature.MyPosts.Models;
using System.Net;
using System.Web.Script.Serialization;
using Feature.MyPosts.Services.Interfaces;

namespace Feature.MyPosts.Services
{
    public class PostService : IPostService
    {
        public List<Post> GetPosts(int count)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString("https://jsonplaceholder.typicode.com/posts?_limit=" + count);
                var serializer = new JavaScriptSerializer();
                var posts = serializer.Deserialize<List<Post>>(json);

                return posts;
            }
        }
    }
}