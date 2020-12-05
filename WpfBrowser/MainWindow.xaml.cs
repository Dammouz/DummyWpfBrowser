using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Navigate();
            }
        }

        private void BookmarkSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxItem = (ComboBoxItem)Bookmark.SelectedItem;
            TextBoxUrl.Text = comboBoxItem.Content.ToString();
        }

        private void OnGoClick(object sender, RoutedEventArgs e)
        {
            Navigate();
        }

        private void Navigate()
        {
            try
            {
                WebBrowserWindow.Source = new Uri(TextBoxUrl.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
