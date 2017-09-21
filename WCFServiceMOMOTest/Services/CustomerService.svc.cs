using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceMOMOTest.Models;
using WCFServiceMOMOTest.DB;

namespace WCFServiceMOMOTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        CustomerDbContext db = new CustomerDbContext();

        public List<Models.Customer> GetAllCustomers()
        {
            return db.Customer.ToList();
        }

        public Models.Customer Get(int CustomerID)
        {
            return db.Customer.Find(CustomerID);
        }

        

       


    }
}
