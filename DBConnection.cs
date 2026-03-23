using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using pr26;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBConnection
{
    public static class DBConnection
    {
        public static string connection_string = "server=localhost;port=3306;database=pr26;uid=root;pwd=000756kuzya";
        public static List<TicketClass> tickets = new List<TicketClass>();

        public static void select_all_from_tickets()
        {
            tickets.Clear();
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                string sql = "SELECT * FROM pr26.tickets;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            MessageBox.Show(reader.Read().ToString());
                            while (reader.Read())
                            {
                                TicketClass tckt = new TicketClass(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7));
                                tickets.Add(tckt);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        
                    }
                }
                conn.Close();
            }
        }
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
