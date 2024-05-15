using RSSCtecak;
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

namespace RSSCtecka
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class AddNewTopic : Window
    {
        public AddNewTopic()
        {
            InitializeComponent();
        }

        private void Button_Zavrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Vytvorit_Click(object sender, RoutedEventArgs e)
        {
            string forbidenChars = "/ :*?\"<>|~\\";
            string topicName = newTopicTextBox.Text;
            if (topicName == "")
            {
                newTopicError.Content = "Jméno nesmí být prázdné";
                return;
            }


            foreach (char curChar in forbidenChars)
            {
                if (topicName.Contains(curChar))
                {
                    newTopicError.Content = "Pole nesmí obsahovat tyto znaky:   / ,   , : , * , ? , \" , < , > , | , ~ , \\ ";
                    newTopicTextBox.Text = "";
                    return;
                }
            }

            switch (Topic.CreateNewTopic(topicName))
            {
                case 1:
                    newTopicError.Content = "Toto téma již existuje";
                    newTopicTextBox.Text = "";
                    return;
            }

            this.Close();
        }

    }
}
