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
using DBConnection;

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
            if (temp_class.date != "") 
            {
                DateTime tm = Convert.ToDateTime(temp_class.date);
                string tm2 = Convert.ToString($"{tm:yyyy-MM-dd}");
                DBConnection.DBConnection.select_all_from_tickets(tm2);
            }
            else if (temp_class.from == "") DBConnection.DBConnection.select_all_from_tickets();
            else DBConnection.DBConnection.select_all_from_tickets(temp_class.from, temp_class.to);

            

            for (int i = 0; i< DBConnection.DBConnection.tickets.Count; i++)
            {
                stack.Children.Add(new element.Item(DBConnection.DBConnection.tickets[i].price.ToString(), DBConnection.DBConnection.tickets[i].from,  DBConnection.DBConnection.tickets[i].to, DBConnection.DBConnection.tickets[i].date1, DBConnection.DBConnection.tickets[i].date2, DBConnection.DBConnection.tickets[i].time1, DBConnection.DBConnection.tickets[i].time2));
            }
        }

        private void ex(object sender, RoutedEventArgs e)
        {
            Ticket_p.Navigate(new Main_page());
            Ticket_p.Content = new Main_page();
            MainWindow.init.MainFrame.Navigate(new Main_page());
        }
    }
}
