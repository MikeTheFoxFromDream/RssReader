using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using RSSCtecak;
using System.Windows.Media;

namespace RSSCtecka.styles
{
    partial class UrlCard
    {
        public void DeleteThisUrl(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ListViewItem listViewItem = FindAncestor<ListViewItem>(button);
            ListView listView = FindAncestor<ListView>(listViewItem);
            TopicSettings window = FindAncestor<TopicSettings>(button);
            int index = listView.Items.IndexOf(listViewItem.DataContext);
            Topic.loadedTopics[window.TopicIndex].RemoveUrl(index);
        }

        private T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }
    }
}
