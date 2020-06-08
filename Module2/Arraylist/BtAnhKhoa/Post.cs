using System;
using System.Collections.Generic;
using System.Text;

namespace BtAnhKhoa
{
    class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public List<int> Rate = new List<int>();
        
        public double AvgRate => CalculatorRate();
        public double CalculatorRate()
        {
            double sum = 0;
            if (Rate.Count > 0)
            {
                foreach (double item in Rate)
                {
                    sum += item;
                }
                return sum / Rate.Count;
            }
            return 0;
        }

        public string Display()
        {
            return $" ID: {Id}\t Tiêu đề: {Title}\t Tác giả: {Author}\t Nội Dung: {Content}\t Đánh giá: {Rate.Count}\t Rate: {AvgRate}\t ";
        }
    }
}
