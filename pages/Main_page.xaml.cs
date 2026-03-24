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
using pr26;

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
            temp_class.from = "";
            temp_class.to = "";
            temp_class.date = "";
        }

        private void go(object sender, RoutedEventArgs e)
        {
            temp_class.from = Convert.ToString(from_txtbx.Text);
            temp_class.to = Convert.ToString(to_txtbx.Text);
            if (datepicker.Text == "") { }
            else temp_class.date = (datepicker.Text);
            MessageBox.Show($"{datepicker.Text}");
            MainWindow.init.MainFrame.Navigate(new Ticket_page());
            
        }

        private void ex(object sender, RoutedEventArgs e)
        {
            MainWindow.init.Close();
        }
    }
}
