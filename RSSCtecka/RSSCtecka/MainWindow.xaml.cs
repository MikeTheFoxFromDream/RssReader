using RSSCtecak;
using RSSCtecka.models;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSSCtecka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        

        public MainWindow()
        {
            InitializeComponent();

            lvEntries.ItemsSource = Topic.loadedTopics;

            //Loading topics
            string[] topicDirs;
            try { topicDirs = Directory.GetDirectories("../../../topics"); }
            catch { throw new Exception("Failed while loading topics"); }

            foreach (string topicFull in topicDirs)
            {
                int indexOfName = topicFull.IndexOf(@"\");
                string topic = topicFull.Substring(indexOfName + 1);
                DateTime lastUpdate = new DateTime();
                try { lastUpdate = DateTime.Parse(File.ReadAllText("../../../topics/" + topic + "/dateTime.txt")); }
                catch { }
                Topic newTopic = new Topic(topic);
                Topic.loadedTopics.Add(newTopic);
            }
        }

        private void Button_New_Topic_Click(object sender, RoutedEventArgs e)
        {
            AddNewTopic aNTWindow = new AddNewTopic();
            aNTWindow.Show();
        }

        private void lvEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lvEntries.SelectedIndex;
            if (i == -1)
                return;
            if (Topic.loadedTopics[i].Updated == false)
            {
                Topic.loadedTopics[i].UpdateFeed();
                Topic.loadedTopics[i].Updated = true;
            }

            lvArticles.ItemsSource = Topic.loadedTopics[i].Feed;
        }

        private void lvArticles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Article article = (Article)lvArticles.SelectedItem;
            if (article == null)
                return;

            if (article.Url == "empty")
                return;

            var psi = new ProcessStartInfo
            {
                FileName = article.Url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            if (lvEntries.SelectedIndex == -1)
                return;
            Topic.loadedTopics[lvEntries.SelectedIndex].UpdateFeed();
        }
    }
}