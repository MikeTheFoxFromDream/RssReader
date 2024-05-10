using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.IO;


namespace RSSReader
{
    internal class Topic
    {
        public string Name { get; set; }

        public string UrlPath { get; set; }

        public List<string> Urls { get; set; }

        public DateTime LastUpdate { get; set; }

        public bool Updated { get; set; }

        public List<SyndicationItem> Feed { get; set; }

        public Topic(string name, string urlPath, DateTime lastUpdate)
        {
            Name = name;
            UrlPath = urlPath;
            Urls = File.ReadAllLines(urlPath).ToList<string>();
            LastUpdate = lastUpdate;
            Updated = false;
            Feed = new List<SyndicationItem>();
        }

        public void UpdateFeed() 
        {
            Updated = true;
            Feed = FeedSetup.FeedDownload(Urls.ToArray());
            LastUpdate = Feed[Feed.Count - 1].PublishDate.DateTime;
        }
    }
}
