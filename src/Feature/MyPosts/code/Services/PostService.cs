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
    [Service(typeof(IPostService))]
    public class PostService : IPostService
    {
        public async Task<List<Post>> GetPostsAsync(string source, int count)
        {
            using (var client = new HttpClient())
            {
                var responseBody = await client.GetStringAsync(source + "?_limit=" + count);
                var posts = new List<Post>();
                var serializer = new JavaScriptSerializer();
                posts = serializer.Deserialize<List<Post>>(responseBody);

                return posts;
            }
        }

        public List<Post> GetPosts(string source, int count)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString($"{source}?_limit=" + count);
                var serializer = new JavaScriptSerializer();
                var posts = serializer.Deserialize<List<Post>>(json);

                return posts;
            }
        }
    }
}