﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceMOMOTest.Models;

namespace WCFServiceMOMOTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetAllCustomers();


        [OperationContract]
        Customer Get(int CustomerID);

        

        

    }
}
