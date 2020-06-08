using System;
using System.Collections.Generic;
using System.Text;

namespace MyNews
{
    class News : INew 
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public int[] Rate = new int[3];

        public double AvgRate { get; private set; }
        public virtual void CalculateAvg()
        {
            double sum = 0;
            foreach (double item in Rate)
            {
                sum += item;
            }
            AvgRate = sum / Rate.Length;
        }

        public virtual void DisPlay()
        {
           Console.WriteLine($" Tiêu đề: {Title}, Tác giả: {Author}, Nội Dung: {Content}, Đánh giá: {AvgRate} ");
        }

    


    }
}
