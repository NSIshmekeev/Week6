using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Article : Edition
    {
        public int Year { get; set; }
        public string JournalTitle { get; set; }
        public int JournalNumber { get; set; }


        public Article(string title, string author, string journalTitle, int year, int journalNumber) : base(title, author)
        {
            Year = year;
            JournalNumber = journalNumber;
            JournalTitle = journalTitle;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, JournalTitle: {JournalTitle}, JournalNumber: {JournalNumber}.");
        }
    }
}
