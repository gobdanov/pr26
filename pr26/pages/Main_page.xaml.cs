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
using pr26.pages;

namespace pr26.pages
{
    /// <summary>
    /// Логика взаимодействия для Main_page.xaml
    /// </summary>
    public partial class Main_page : Page
    {
        public Main_page()
        {
            InitializeComponent();
        }

        private void go(object sender, RoutedEventArgs e)
        {
            Main_p.Navigate(new Ticket_page());
            Main_p.Content = new Ticket_page();
        }

        private void ex(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
