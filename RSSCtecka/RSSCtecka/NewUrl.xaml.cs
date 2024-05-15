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
    /// Interakční logika pro NewUrl.xaml
    /// </summary>
    public partial class NewUrl : Window
    {

        private int TopicIndex {  get; set; }

        public NewUrl(int index)
        {
            TopicIndex = index;
            InitializeComponent();
        }

        private void Button_Zavrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Pridat_Click(object sender, RoutedEventArgs e)
        {
            string newUrl = UrlTextBox.Text;
            if (newUrl == "")
            {
                urlError.Content = "Odkaz nesmí být prázdný";
                return;
            }

            if (Topic.loadedTopics[TopicIndex].Urls.Contains(newUrl))
            {
                urlError.Content = "Tento odkaz už je na listu";
                return;
            }

            Topic.loadedTopics[TopicIndex].AddUrl(newUrl);

            this.Close();
        }
    }
}
