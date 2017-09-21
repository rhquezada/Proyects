using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WCFServiceMOMOTest.Models;

namespace WCFServiceMOMOTest.DB
{
    public class CustomerDbContext : DbContext
    {

        public CustomerDbContext()
            : base("CustomerDbContext")
        { }

        public DbSet<Customer> Customer { get; set; }


        public DbSet<Orders> orders { get; set; }


    }

    public class CustomerDbInitializer : DropCreateDatabaseIfModelChanges<CustomerDbContext> { 
        protected override void Seed(CustomerDbContext context)
        {
            context.Customer.Add(new Customer() { CustomerID = 1000, CompanyName = "GBT", Address = "Paseo General Escalon", Country="El Salvador", ContractName="TBI234-123", Telephone=22345467  });
            context.SaveChanges();

           
        }

        

        }

    }



