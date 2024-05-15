using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
            ImgSource = "https://t3.ftcdn.net/jpg/05/31/99/72/360_F_531997233_Uo7u6Cwj2qjtREfv11x7kkMyk53mTku7.jpg";
        }
    }
}
