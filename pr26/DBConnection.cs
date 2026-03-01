using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace DBConnection
{
    public static class DBConnection
    {
        public static string connection_string = "server=localhost;port=3306;database=pr26;uid=root;pwd=000756kuzya";
        public static void connect_to_database()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connection_string);
                conn.Open();
                MessageBox.Show("подлючение успешно!!");
                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
