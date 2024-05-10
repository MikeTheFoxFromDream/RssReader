using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSSReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //Loading topics
            string[] topicDirs;
            try { topicDirs = Directory.GetDirectories("../../../topics"); }
            catch { throw new Exception("Failed while loading topics"); }
            
            foreach(string topicFull in topicDirs) 
            {
                int indexOfName = topicFull.IndexOf(@"\");
                string topic = topicFull.Substring(indexOfName + 1);
                DateTime lastUpdate = new DateTime();
                try { lastUpdate = DateTime.Parse(File.ReadAllText("../../../topics/" + topic + "/dateTime.txt")); }
                catch { }
                Topic newTopic = new Topic(topic, "../../../topics/" + topic + "/url.txt", lastUpdate);
                lvEntries.Items.Add(newTopic);
            }
        }
    }
}