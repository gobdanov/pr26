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

namespace pr26.pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket_page.xaml
    /// </summary>
    public partial class Ticket_page : Page
    {
        public Ticket_page()
        {
            InitializeComponent();
        }

        private void ex(object sender, RoutedEventArgs e)
        {
            Ticket_p.Navigate(new Main_page());
            Ticket_p.Content = new Main_page();
            MainWindow.init.MainFrame.Navigate(new Main_page());
        }
    }
}
