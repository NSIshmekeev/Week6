using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Ebook : Edition
    {
        public string Url { get; set; }
        public string Annotation { get; set; }

        public Ebook(string title, string author, string url, string annotation) : base(title, author)
        { 
            Url = url;
            Annotation = annotation;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Ebook: {Title}, Author: {Author}, URL: {Url}, Annotation: {Annotation}");
        }
    }
}
