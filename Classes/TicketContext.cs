using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev26pr.Classes
{
    public class TicketContext : Ticket
    {
        public TicketContext(string from, string to, int price, DateTime time_start, DateTime time_end) : base(from, to, price, time_start, time_end) { }

        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();

            MySqlConnection connection = WorkingDB.Connection.OpenConnection();
            MySqlDataReader ticketQuery = WorkingDB.Connection.Query("SELECT * FROM 'airlines'.'Tickets';", connection);
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5)
                    ));
            }


            WorkingDB.Connection.CloseConnection(connection);
            return allTickets;
        } 
    }
}
