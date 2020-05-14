using System;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaTests
{
    internal class Content
    {
        internal Dictionary<User, List<Post>> PublishedPosts { get; set; } = new Dictionary<User, List<Post>>();
        internal Dictionary<User, List<Post>> LikedPosts { get; set; } = new Dictionary<User, List<Post>>();
        internal Dictionary<User, List<Post>> SharedPosts { get; set; } = new Dictionary<User, List<Post>>();

        internal void Publish(User user, Post post)
        {
            if (PublishedPosts.ContainsKey(user))
            {
                PublishedPosts[user].Add(post);
            }
            else
            {
                var posts = new List<Post> { post };
                PublishedPosts.Add(user, posts);
            }
        }

        internal IEnumerable<Post> GetFeed(IEnumerable<User> follows)
        {
            var feedPublished = from kvp in PublishedPosts
                                where follows.Contains(kvp.Key)
                                select kvp.Value;

            var feedLiked = from kvp in LikedPosts
                                where follows.Contains(kvp.Key)
                                select kvp.Value;

            var feedShared = from kvp in SharedPosts
                                where follows.Contains(kvp.Key)
                                select kvp.Value;


            return feedPublished
                    .SelectMany(lst => from post in lst select post)
                    .Union(feedLiked.SelectMany(lst => from post in lst select post))
                    .Union(feedShared.SelectMany(lst => from post in lst select post));
        }

        internal void Like(User user, Post post)
        {
            if (LikedPosts.ContainsKey(user))
            {
                LikedPosts[user].Add(post);
            }
            else
            {
                var posts = new List<Post> { post };
                LikedPosts.Add(user, posts);
            }
        }

        internal void Share(User user, Post post)
        {
            if (SharedPosts.ContainsKey(user))
            {
                SharedPosts[user].Add(post);
            }
            else
            {
                var posts = new List<Post> { post };
                SharedPosts.Add(user, posts);
            }
        }
    }
}