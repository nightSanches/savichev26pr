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

namespace savichev26pr.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(TicketContext item)
        {
            InitializeComponent();
            lPrice.Content = item.price + "Руб";
            
            fromTime.Content = Convert.ToDateTime(item.time_start).ToString("HH:mm");
            fromData.Content = Convert.ToDateTime(item.time_start).ToString("yyyy.MM.dd");
            from.Content = item.from;
            toTime.Content = Convert.ToDateTime(item.time_end).ToString("HH:mm");
            toData.Content = Convert.ToDateTime(item.time_end).ToString("yyyy.MM.dd");
            to.Content = item.to;
            DateTime time_end_str = Convert.ToDateTime(item.time_end);
            TimeSpan waytime = time_end_str.Subtract(Convert.ToDateTime(item.time_start));
            way.Content = $"В пути: {waytime.Hours}:{waytime.Minutes}";
        }
    }
}
