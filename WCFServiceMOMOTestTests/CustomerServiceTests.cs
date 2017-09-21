using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFServiceMOMOTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceMOMOTest.DB;
using WCFServiceMOMOTest.Services;



namespace WCFServiceMOMOTest.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {
        [TestMethod()]
        public void GetAllCustomersTest()
        {
            CustomerDbContext db = new CustomerDbContext();
            DbSet<Customer> Customer  = new DbSet<Customer>();

            int Current = 0;

            customer = db.customer.ToList();


            


        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

       
    }
}