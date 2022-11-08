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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestTask.Model;

namespace TestTask.Frames
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<Page> pages = new List<Page>();
        public MainPage()
        {
            InitializeComponent();
            pages.Add(new Table(MainFrame));
            MainFrame.Content = pages[0];
        }

        private void ToTableFrame(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = pages[0];
            BackMenuButton.Visibility = Visibility.Hidden;
        }

     
    }
}
