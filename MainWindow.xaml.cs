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

namespace savichev26pr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(pages.main);
        }
        public void OpenPages(pages _page)
        {
            if (_page == pages.main)
            {
                frame.Navigate(new Pages.Main());
            }
        }
        public enum pages
        {
            main
        }
        public List<Ticket> ticketClasses = new List<Ticket>();

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
