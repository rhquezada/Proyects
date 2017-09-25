using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFServiceMOMOTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceMOMOTest.DB;
using WCFServiceMOMOTest.Services;
using WCFServiceMOMOTest.Models;



namespace WCFServiceMOMOTest.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {
        //Global
        CustomerService  client = new CustomerService();
        CustomerDbContext db = new CustomerDbContext();


        [TestMethod]
        public void GetCustomersTest()
        {
            {

                //Arrange
                int CustomerID = 1;
                Customer expectedCustomer = new Customer()
                {
                    Address = "San Salvador",
                    CompanyName = "BMP",
                    ContractName = "BMP123",
                    Country = "El Salvador",
                    CustomerID = 1,
                    Telephone = 22345676
                };

                //Act
                Customer actualCustomer = client.Get(CustomerID);

                //Assert
                Assert.AreEqual(expectedCustomer.CustomerID, actualCustomer.CustomerID);
                Assert.AreEqual(expectedCustomer.Address, actualCustomer.Address);
                Assert.AreEqual(expectedCustomer.CompanyName, actualCustomer.CompanyName);
                Assert.AreEqual(expectedCustomer.ContractName, actualCustomer.ContractName);
                Assert.AreEqual(expectedCustomer.Country, actualCustomer.Country);
                Assert.AreEqual(expectedCustomer.Telephone, actualCustomer.Telephone);
            }



        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

       
    }
}