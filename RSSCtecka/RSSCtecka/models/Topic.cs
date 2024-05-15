using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.IO;
using System.DirectoryServices;
using System.Security.Policy;
using RSSCtecka.models;
using RSSCtecka.Uti;
using System.Xml.Linq;


namespace RSSCtecak
{
    public class Topic
    {
        public string Name { get; set; }

        public string UrlPath { get; set; }

        public ObservableList<string> Urls { get; set; }

        public string DateTimePath { get; set; }

        public DateTime LastUpdate { get; set; }

        public bool Updated { get; set; }

        public ObservableList<Article> Feed { get; set; }

        public Topic(string name)
        {
            Name = name;
            string path = "../../../topics/" + name;
            UrlPath = path + "/url.txt";
            Urls = CreateObservableListUrl(File.ReadAllLines(UrlPath));
            DateTimePath = path + "/dateTime.txt";
            LastUpdate = DateTime.Parse(File.ReadAllText(DateTimePath));
            Updated = false;
            Feed = new ObservableList<Article>();
        }

        public void UpdateFeed()
        {
            Updated = true;
            Feed = FeedSetup.FeedDownload(Urls.ToArray());
            if (Feed.Count != 0)
            {
                LastUpdate = Feed[Feed.Count - 1].PublishDate;
                File.WriteAllText(DateTimePath, LastUpdate.ToString());
            }
        }

        public void AddUrl(string url)
        {
            Urls.Add(url);
            string[] urlAr = { url };
            File.AppendAllLines(UrlPath, urlAr);
        }

        public void RemoveUrl(int index) 
        {
            Urls.RemoveAt(index);
            File.WriteAllLines(UrlPath, Urls.ToArray());

        }

        public static byte CreateNewTopic(string name)
        {
            if (Directory.Exists("../../../topics/" + name))
                return 1;

            Directory.CreateDirectory("../../../topics/" + name);
            StreamWriter sr = File.CreateText("../../../topics/" + name + "/url.txt");
            sr.Close();
            sr = File.CreateText("../../../topics/" + name + "/dateTime.txt");
            sr.Close();
            var temp = new DateTime();
            File.WriteAllText("../../../topics/" + name + "/dateTime.txt", temp.ToString());
            Topic newTopic = new Topic(name);
            Topic.loadedTopics.Add(newTopic);
            return 0;

        }

        public static byte RemoveTopic(int i)
        {
            var a = loadedTopics[i].Name;
            Directory.Delete("../../../topics/" + loadedTopics[i].Name, true);
            loadedTopics.RemoveAt(i);
            return 0;
        }

        public static ObservableList<Topic> loadedTopics = new ObservableList<Topic>();

        private static ObservableList<string> CreateObservableListUrl(string[] values)
        {
                ObservableList<string> newList = new ObservableList<string>();
                foreach (string item in values)
                {
                    newList.Add((string)item);
                }

                return newList;
        }

    }

    
}
