using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFServiceMOMOTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceMOMOTest.DB;
using WCFServiceMOMOTest.Models;
using WCFServiceMOMOTest.Services;


namespace WCFServiceMOMOTest.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {

        CustomerService client = new CustomerService();
        OrderService clientOS = new OrderService();
        CustomerDbContext db = new CustomerDbContext();

        [TestMethod]
        public void Test_Get()
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

        public void Test_GetAllCustomers()
        {
            //Arrange
            int i = 0;
            List<Customer> expectedCustomer = db.Customer.ToList();

            //Act
            List<Customer> actualCustomer = client.GetAllCustomers().ToList();

            //Assert
            foreach (var c in actualCustomer)
            {

                Assert.AreEqual(c.CompanyName, expectedCustomer[i].CompanyName);
                Assert.AreEqual(c.ContractName, expectedCustomer[i].ContractName);
                Assert.AreEqual(c.Telephone, expectedCustomer[i].Telephone);
                i++;
            }
        }

        [TestMethod]
        public void Test_GetCustomerOrderHistory()
        {
            //Arrange
            
            int i = 0;
            List<Orders> expectedOrders = db.orders.ToList();

            //Act
            List<Orders> actualOrders = clientOS.GetAllOrders().ToList();

            //Assert
            foreach (var o in actualOrders)
            {
                Assert.AreEqual(o.Amount, expectedOrders[i].Amount);
                Assert.AreEqual(o.Description, expectedOrders[i].Description);
                i++;
            }
        }

        [TestMethod]
        public void Test_GetCustomerOrder()
        {
            //Arrange
            int Id = 4;
            Orders expectedOrder = new Orders()
            {
                OrdersId = Id,
                Description = "Item3",
                Date = "2017-06-19 00:00:00.000",
                Amount = 133,
                Quantity = 1
              
            };

            //Act
            Orders actualOrder = clientOS.Get(Id);

            //Assert
            Assert.AreEqual(actualOrder.OrdersId, actualOrder.OrdersId);
            Assert.AreEqual(actualOrder.Description, actualOrder.Description);
            Assert.AreEqual(actualOrder.Date, actualOrder.Date);
            Assert.AreEqual(actualOrder.Amount, actualOrder.Amount);
            Assert.AreEqual(actualOrder.Quantity, actualOrder.Quantity);
            

        }

    }
}