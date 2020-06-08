using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BtAnhKhoa
{
    class ListForum
    {
        public List<Post> listPost = new List<Post>();
        public void CreatPost(Post post)
        { 
            listPost.Add(post);
        }
        public void ShowPost()
        {
            foreach(Post item in listPost)
            {
                Console.WriteLine(item.Display());
            }
        }
        public Post CheckID(int postId)
        {
            foreach (Post item in listPost)
            {
                if (item.Id.Equals(postId))
                {
                    return item;
                }
            }
            return null;
        }
        public void UpdatePost(int postId, string content)
        {
            Post item = CheckID(postId);
            if (item != null)
            {
                item.Content = content;
            }
            else
            {
                Console.WriteLine("Not found !!!");
            }
        }
        public void RemovePost(int postId)
        {
            Post item = CheckID(postId);
            if (item != null)
            {
                listPost.Remove(item);
            }
            else
            {
                Console.WriteLine("Not found !!!");
            }
        }
        public void RaitingPost(int postId, int raiting)
        {
            Post item = CheckID(postId);
            if (item != null)
            {
                item.Rate.Add(raiting);
            }
            else
            {
                Console.WriteLine("Not found !!!");
            }
        }
    }
}
