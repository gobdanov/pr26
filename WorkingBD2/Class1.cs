using MySql.Data;
using MySql.Data.MySqlClient;

namespace WorkingBD2
{
    public class WorkingBD
    {
        ticketsClasses.Clear();
        static string connection_string = "server = localhost;port=3306;database=pr26;uid=root;pwr=000756kuzya";
        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connection_string);
        conn.Open();

        MySqlDataReader ticket_query = WorkingBD.Query("select * from pr26.Tickets;", conn);
    }

}
