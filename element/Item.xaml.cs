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

namespace pr26.element
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }
        public Item(string price, string from, string to, string date1, string date2, string time1, string time2)
        {
            InitializeComponent();
            price_lbl.Content = $"{price}р";
            from_lbl.Content = from;
            to_lbl.Content = to;
            date1_lbl.Content = date1;
            date2_lbl.Content = date2;
            time1_lbl.Content = time1;
            time2_lbl.Content = time2;
        }
    }
}
