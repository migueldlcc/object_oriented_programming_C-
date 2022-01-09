pusing System;
using System.Collections.Generic;
using System.Text;

namespace COMS201_D6
{
    class LineItem
    {
        public string LineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime ShipDate { get; set; }
    }
}
