using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ls.key2uni.Entities
{
    public interface ICustomerServices
    {
        IQueryable<Customer> Customer { get; }
        void Save();
    }
}
