using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using RSSCtecak;

namespace RSSCtecka
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class TopicSettings : Window
    {

        public int TopicIndex { get; private set; }

        public TopicSettings()
        {
            InitializeComponent();
        }

        public TopicSettings(int topicIndex)
        { 
            TopicIndex = topicIndex;
            InitializeComponent();
            UrlList.ItemsSource = Topic.loadedTopics[TopicIndex].Urls;
        }

        private void Button_Zrusit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Novy_Odkaz_Click(object sender, RoutedEventArgs e)
        {
            NewUrl newUrl = new NewUrl(TopicIndex);
            newUrl.Show();

        }

    }
}
