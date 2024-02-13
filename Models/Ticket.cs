using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev26pr
{
    public class Ticket
    {
        public string from { get; set; }
        public string to { get; set; }
        public int price { get; set; }
        public string time_start { get; set; }
        public string time_end { get; set; }

        public Ticket() { }

        public Ticket(string from, string to, int price, string time_start, string time_end)
        {
            this.from = from;
            this.to = to;
            this.price = price;
            this.time_start = time_start;
            this.time_end = time_end;
        }
    }
}
