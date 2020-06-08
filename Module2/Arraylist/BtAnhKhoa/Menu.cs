using System;
using System.Collections.Generic;
using System.Text;

namespace BtAnhKhoa
{
    class Menu
    {
        public static int PostID = 0;
        public static Forum forum = new Forum();
        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT");
                Console.WriteLine("1. Creat Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Posts");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");

                Console.Write("Please select an option (1-7): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 7)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 7);

        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                CreateMenu(out selected);
                switch (selected)
                {
                    case 1:
                        {
                            Console.Clear();
                            Creat();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Update();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Remove();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Show();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Search();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Raiting();
                            break;
                        }
                    case 7:
                        {
                            Environment.Exit(0);
                            break;
                        }

                }
            }
            while (selected != 7);
        }
        public static void Creat()
        {
            PostID += 1;
            Post post = new Post();
            Console.WriteLine("Nhập Title: ");
            post.Title = Console.ReadLine();
            Console.WriteLine("Nhập Author: ");
            post.Author = Console.ReadLine();
            Console.WriteLine("Nhập Content: ");
            post.Content = Console.ReadLine();
            post.Id = PostID;
            forum.CreatPost(post);    
        }
        public static void Show()
        {
            forum.ShowPost();
        }
        public static void Update()
        {
            Console.WriteLine("Nhập Post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Post Content: ");
            var content = Console.ReadLine();
            forum.UpdatePost(content, id);

        }
        public static void Search()
        {
            Console.WriteLine("Nhập Keyword: ");
            string keyword = Console.ReadLine();
            forum.SearchPost(keyword);
        }
        public static void Remove()
        {
            Console.WriteLine("Nhập Post Id: ");
            var id = int.Parse(Console.ReadLine());
            forum.RemovePost(id);
        }
        public static void Raiting()
        {
            Console.WriteLine("Nhập Post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Raiting: ");
            var raiting = int.Parse(Console.ReadLine());
            forum.RaitingPost(id, raiting);

        }
    }
}
