using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BusinessEntities
{
    class Customer: BaseBusinessEntity
    {
       public Customer(): base()
        {
            
        }

        public IEnumerable<LinqToSql.Customer> getAllCustomers()
        {
            IEnumerable<LinqToSql.Customer> c = this.db.Customers;
            return c;

        }

        public bool deleteCustomer(string ID)
        {
            LinqToSql.Customer c = this.db.Customers.FirstOrDefault(k => k.CustomerID == ID);
            db.Customers.DeleteOnSubmit(c);
            db.SubmitChanges();
            return true;

        }
    }
}
