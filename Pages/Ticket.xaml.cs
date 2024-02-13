using savichev26pr.Classes;
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

namespace savichev26pr.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        public List<TicketContext> AllTickets { get; set; }
        public Ticket(string From, string To)
        {
            InitializeComponent();
            AllTickets = TicketContext.AllTickets().FindAll(x => (x.from == From && To=="") || (x.to == To && From == "") || (x.from == From && x.to == To));
            CreateUI();
        }

        public void CreateUI()
        {
            foreach (TicketContext item in AllTickets)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
