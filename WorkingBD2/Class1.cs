using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace WorkingBD2
{
    public static class WorkingBD
    {
        static string connection_string = "server=localhost;port=3306;database=pr26;uid=root;pwr=000756kuzya";

        static public void connect()
        {
            try
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connection_string);
                conn.Open();
                MessageBox.Show("подключение успешно!!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }

}
