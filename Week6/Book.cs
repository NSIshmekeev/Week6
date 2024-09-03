using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Book : Edition
    {
        public int Year { get; set; }
        public string Publisher { get; set; }

        public Book (string title, string author, int year, string publisher) : base(title, author)
        {
            Year = year;
            Publisher = publisher;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Publisher: {Publisher}");
        }
    }
}
