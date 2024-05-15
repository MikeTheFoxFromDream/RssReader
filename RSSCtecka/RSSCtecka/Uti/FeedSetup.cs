using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Linq.Expressions;
using RSSCtecka.models;

namespace RSSCtecka.Uti;

public static class FeedSetup
{
    public static ObservableList<Article> FeedDownload(string[] url)
    {
        ObservableList<Article> itemList = new ObservableList<Article>();

        foreach (var curUrl in url)
        {
            var reader = XmlReader.Create(curUrl);
            var feed = SyndicationFeed.Load(reader);

            foreach (var i in feed.Items)
            {
                Article curArticle = null;
                string name;
                string baseUrl = "empty";

                try { name = i.Authors[0].Name; }
                catch{ name = "anonymus"; }

                try { baseUrl = i.Links[0].Uri.ToString(); }
                catch {baseUrl = "empty"; }


                curArticle = new Article(name, i.Title.Text, i.PublishDate.DateTime, baseUrl);
                itemList.Add(curArticle);
                
            }
            reader.Close();
        }

        itemList.Sort((item1, item2) => item2.PublishDate.CompareTo(item1.PublishDate));

        return itemList;
    }
}