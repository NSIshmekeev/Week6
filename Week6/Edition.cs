using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public abstract class Edition
    {
        public string Title { get; set; }
        public string Author { get; set; }

        protected Edition(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public abstract void DisplayInfo();
        public bool IsMatchingAuthor(string author)
        {
            return Author.Equals(author, StringComparison.OrdinalIgnoreCase);
        }
    }
}
