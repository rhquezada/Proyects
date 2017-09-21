using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceMOMOTest.Models;
using WCFServiceMOMOTest.DB;


namespace WCFServiceMOMOTest.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.

    public class OrderService : IOrderService
    {
        CustomerDbContext db = new CustomerDbContext();

        public List<Models.Orders> GetAllOrders()
        {
            return db.orders.ToList();
        }

        public Models.Orders Get(int OrdersId)
        {
            return db.orders.Find(OrdersId);
        }

        




    }
}