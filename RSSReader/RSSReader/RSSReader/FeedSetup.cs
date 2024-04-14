using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;

namespace RSSReader;

public class FeedSetup
{
    public static List<SyndicationItem> FeedDownload(string[] url)
    {
        List<SyndicationItem> itemList = new List<SyndicationItem>();

        foreach (var curUrl in url)
        {
            var reader = XmlReader.Create(curUrl);
            var feed = SyndicationFeed.Load(reader);

            foreach (var i in feed.Items){
                itemList.Add(i);
            }
            reader.Close();
        }

        itemList.Sort((item1, item2) => item2.PublishDate.DateTime.CompareTo(item1.PublishDate.DateTime));

        return itemList;
    }
}