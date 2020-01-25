using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT365_W3_MegaDesk
{
    public class DeskQuote
    {
        public int id { get; set; }
        public String customerName { get; set; }
        public Desk desk { get; set; }
        public Globals.RushType rushType;
        public double totalQuote { get; set; }

        public override string ToString()
        {
            return String.Format("ID {0,-3} Customer {1,-10}  Total {2:C}", id,customerName,totalQuote);
        }

    }
}
