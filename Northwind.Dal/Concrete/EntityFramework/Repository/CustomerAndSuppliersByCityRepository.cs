using Microsoft.EntityFrameworkCore;
using Northwind.Entity.Models;
using Northwnd.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerAndSuppliersByCityRepository : GenericRepository<CustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityRepository
    {
        public CustomerAndSuppliersByCityRepository(DbContext context) : base(context)
        {
        }

        public IQueryable<CustomerAndSuppliersByCity> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
