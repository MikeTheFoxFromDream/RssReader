using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSCtecka.models
{
    public class Article
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImgSource { get; set; }
        public string Url { get; set; }

        public Article(string name, string title, DateTime date, string url)
        {
            Name = name;
            Title = title;
            PublishDate = date;
            Url = url;
            ImgSource = "C:\\Users\\Admin\\source\\repos\\RSSCtecka\\RSSCtecka\\src\\img.jpg";
        }
    }
}
