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
using DBConnection;

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
            LoadTickets();
        }

        public void LoadTickets()
        {
            ticketClasses.Clear();
            DBConnection.DBConnection.connect_to_database();
        }
    }
}
