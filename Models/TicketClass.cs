using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev26pr
{
    public class TicketClass
    {
        public int price { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime time_start { get; set; }
        public DateTime time_end { get; set; }

        public TicketClass() { }

        public TicketClass(string from, string to, int price, DateTime time_start, DateTime time_end)
        {
            this.from = from;
            this.to = to;
            this.price = price;
            this.time_start = time_start;
            this.time_end = time_end;
        }
        public static List<TicketClass> AllTickets()
        {
            List<TicketClass> allTickets = new List<TicketClass>();

            MySqlConnection connection = WorkingBD.Connectional.OpenConnection();
            MySqlDataReader ticketQuery = WorkingBD.Connectional.Query("SELECT * FROM airlines.Tickets;", connection);
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketClass(
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5)
                    ));
            }
            WorkingBD.Connectional.CloseConnection(connection);

            return allTickets;
        }
    }
}
