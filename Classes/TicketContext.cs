using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace savichev26pr.Classes
{
    public class TicketContext : Ticket
    {
        public TicketContext(string from, string to, int price, string time_start, string time_end) : base(from, to, price, time_start, time_end) { }

        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();

            MySqlConnection connection = WorkingDB.Connection.OpenConnection();
            MySqlDataReader ticketQuery = WorkingDB.Connection.Query("SELECT * FROM `airlines`.`Tickets`", connection);
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(4),
                    ticketQuery.GetString(5)
                    ));
            }


            WorkingDB.Connection.CloseConnection(connection);
            return allTickets;
        } 
    }
}
