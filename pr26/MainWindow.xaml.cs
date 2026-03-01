using MySql.Data.MySqlClient;
using pr26.pages;
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

namespace pr26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public List<TicketClass> ticketClasses = new List<TicketClass>();

        public MainWindow()
        {
            InitializeComponent();
            init = this;
            MainFrame.Navigate(new Main_page());
            MainFrame.Content = new Main_page();
        }

        public void LoadTickets()
        {
            ticketClasses.Clear();
            string connection_string = "server = localhost;port=3306;database=pr26;uid=root;pwr=000756kuzya";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();

            MySqlDataReader tickets_query = WorkingBD()
        }
    }
}
