using System;
using System.Collections.Generic;
using System.Text;

namespace BtAnhKhoa
{
    class DictionaryForum
    {
        public Dictionary<int, Post> dictionaryPost = new Dictionary<int, Post>();
        public void CreatPost(Post post)
        {
            dictionaryPost.Add(post.Id, post);
        }
        public bool CheckPost(int postId)
        {
            foreach(Post item in dictionaryPost.Values)
            {
                if (item.Id.Equals(postId))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
