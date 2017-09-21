﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceMOMOTest.Models;

namespace WCFServiceMOMOTest.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        List<Orders> GetAllOrders();


        [OperationContract]
        Orders Get(int OrdersId);

        
        
    }
}
