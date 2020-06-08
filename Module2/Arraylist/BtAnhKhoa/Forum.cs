using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BtAnhKhoa
{
    class Forum
    {
        public SortedList<int,Post> Posts = new SortedList<int,Post>();
        public void CreatPost(Post post)
        {
            Posts.Add(post.Id, post);
        }
        public void UpdatePost(string content, int postId)
        {
            if (CheckPost(postId))
            {
                Posts[postId].Content = content;
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public bool CheckPost(int postId)
        {
            return Posts.Keys.Contains(postId);
        }
        public void RemovePost(int postId)
        {
            if (CheckPost(postId))
            {
                Posts.RemoveAt(postId-1);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public void SearchPost(string keyword)
        {
            keyword = keyword.ToLower();
            foreach (var item in Posts.Values)
            {
                if (keyword.Contains(item.Author.ToLower()) || keyword.Contains(item.Content.ToLower()))
                {
                    Console.WriteLine(item.Display());
                }
            }
        }

        public void ShowPost()
        {
            foreach (var item in Posts.Values)
            {
                Console.WriteLine(item.Display());
            }
        }
        public void RaitingPost(int postId,int rate)
        {
            if (CheckPost(postId))
            {
                Posts[postId].Rate.Add(rate);
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }

    }
}
