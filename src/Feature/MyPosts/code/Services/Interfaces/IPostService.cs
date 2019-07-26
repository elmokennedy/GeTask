using System.Collections.Generic;
using Feature.MyPosts.Models;
using System.Threading.Tasks;

namespace Feature.MyPosts.Services.Interfaces
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync(string source, int count);

        List<Post> GetPosts(string source, int count);
    }
}
