using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceMOMOTest.Models
{
    public class Orders
    {
        
        public int OrdersId { get; set; }

        public String Description { get; set; }

        public string Date { get; set; }

        public int Amount { get; set; }

        public int Quantity { get; set; }


    }
}