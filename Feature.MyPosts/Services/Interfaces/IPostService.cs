using System.Collections.Generic;
using Feature.MyPosts.Models;

namespace Feature.MyPosts.Services.Interfaces
{
    public interface IPostService
    {
        List<Post> GetPosts(int count);
    }
}
