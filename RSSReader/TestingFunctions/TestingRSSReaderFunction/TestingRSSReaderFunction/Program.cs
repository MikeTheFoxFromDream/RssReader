using System.Xml;
using System.ServiceModel.Syndication;

string[] url =
{
    @"http://feeds.feedburner.com/techulator/articles",
    @"C:\Users\Admin\Documents\GitHub\RssReader\RSSReader\TestingFunctions\TestingRSSReaderFunction\TestingRSSReaderFunction\TestRSSFiles\TestingRSS.rss"
};

List<SyndicationItem> g = new List<SyndicationItem>();

foreach (var curURL in url)
{
    var reader = XmlReader.Create(curURL);
    var feed = SyndicationFeed.Load(reader);

    foreach (var i in feed.Items){
        g.Add(i);
    }
    reader.Close();
}

g.Sort(delegate(SyndicationItem item1, SyndicationItem item2)
{
    return item2.PublishDate.DateTime.CompareTo(item1.PublishDate.DateTime);
});

foreach (var i in g)
{
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine(i.Title.Text);
    try
    {
        Console.WriteLine(i.Authors[0].Name);
    }
    catch
    {
        Console.WriteLine("anonymus"); 
    }

    try
    {
        Console.WriteLine(i.PublishDate.DateTime);
    }
    catch
    {
        Console.WriteLine("unknown");
    }
}
Console.WriteLine();
Console.WriteLine(g.Count());
Console.WriteLine();
Console.WriteLine("Press any button...");
Console.ReadKey();