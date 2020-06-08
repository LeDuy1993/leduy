using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyNews
{
    public class NewsFunction
    {
        public static ArrayList newsList = new ArrayList() {
        new News()
        {
            ID = 1,
            Title = "Ăn Nhậu",
            Author = "Pháp",
            Content = "Không say không về",
            Rate = new int[3] {4,5,6}
        },
         new News()
        {
            ID = 2,
            Title = "Ăn Học",
            Author = "Thường",
            Content = "Không xong không về",
           Rate = new int[3] {4,5,6}
        },
          new News()
        {
            ID = 2,
            Title = "Game",
            Author = "Vũ",
            Content = "Xuyên màn đêm",
            Rate = new int[3] {4,5,6}
        }
        };

        public void InsertList(int id, string title, string author, string content, int rate1, int rate2, int rate3)
        {
            newsList.Add(new News()
            {
                ID = id,
                Title = title,
                Author = author,
                Content = content,
                Rate = new int[3] { rate1, rate2, rate3 }

            });
        }
        public void ViewList()
        {
            foreach (News item in newsList)
            {
                item.CalculateAvg();
                item.DisPlay();
            }
        }
        public void SortList()
        {
            newsList.Sort(new SortList());
            ViewList();
        }
    }
}
