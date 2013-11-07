using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ls.key2uni.Entities;

namespace ls.key2uni.Domain.Infrastructure
{
    public class CustomerDb : DbContext, ICustomerServices
    {
        public CustomerDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<Customer> Customers { get; set; }

        IQueryable<Customer> ICustomerServices.Customer
        {
            get { return Customers; }
        }

        void ICustomerServices.Save()
        {
            SaveChanges();
        }
    }
}