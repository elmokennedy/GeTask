using System.Collections.Generic;
using Feature.MyPosts.Models;
using System.Web.Script.Serialization;
using Feature.MyPosts.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using Foundation.DependencyInjection.Attributes;
using System.Net;

namespace Feature.MyPosts.Services
{
    using System;

    [Service(typeof(IPostService))]
    public class PostService : IPostService
    {
        public async Task<List<Post>> GetPostsAsync(string source, int count)
        {
            using (var client = new HttpClient())
            {
                List<Post> posts;

                try
                {
                    var responseBody = await client.GetStringAsync($"{source}?_limit={count}");
                    var serializer = new JavaScriptSerializer();
                    posts = serializer.Deserialize<List<Post>>(responseBody);
                }
                catch
                {
                    posts = new List<Post>();
                }

                return posts;
            }
        }

        public List<Post> GetPosts(string source, int count)
        {
            using (var client = new WebClient())
            {
                List<Post> posts;

                try
                {
                    var json = client.DownloadString($"{source}?_limit={count}");
                    var serializer = new JavaScriptSerializer();
                    posts = serializer.Deserialize<List<Post>>(json);
                }
                catch
                {
                    posts = new List<Post>();
                }

                return posts;
            }
        }
    }
}