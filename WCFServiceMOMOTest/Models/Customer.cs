using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceMOMOTest.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public string ContractName { get; set; }

        public int Telephone { get; set; }

    }
}