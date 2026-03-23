using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr26
{
    public class TicketClass
    {
        public int id {  get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string date1 { get; set; }
        public string date2 {  get; set; }
        public string time1 { get; set; }
        public string time2 { get; set; }
        public int price {  get; set; }
        public TicketClass(int id, string from, string to, string date1, string date2, string time1, string time2, int price)
        {
            this.id = id;
            this.from = from;
            this.to = to;
            this.date1 = date1;
            this.date2 = date2;
            this.time1 = time1;
            this.time2 = time2;
            this.price = price;
        }
    }
}
