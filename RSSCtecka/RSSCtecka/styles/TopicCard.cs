using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using RSSCtecak;

namespace RSSCtecka.styles
{
    public partial class TopicCard
    {
        public void DeleteThisTopic(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ListViewItem listViewItem = FindAncestor<ListViewItem>(button);
            ListView listView = FindAncestor<ListView>(listViewItem);
            int index = listView.Items.IndexOf(listViewItem.DataContext);
            Topic.RemoveTopic(index);
        }

        public void TopicSettings(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ListViewItem listViewItem = FindAncestor<ListViewItem>(button);
            ListView listView = FindAncestor<ListView>(listViewItem);
            int index = listView.Items.IndexOf(listViewItem.DataContext);
            TopicSettings topicSettings = new TopicSettings(index);
            topicSettings.Show();
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
