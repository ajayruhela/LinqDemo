using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE=LinqToSql.BusinessEntities;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            BE.Customer c = new BE.Customer();
            //Delete customer id AROUT
            bool ifdeleted = c.deleteCustomer("AROUT");
            Console.WriteLine(ifdeleted);

            //Get All Customers
            var allcustomers = c.getAllCustomers();

            foreach (Customer ct in allcustomers)
                Console.WriteLine(ct.CompanyName + " " + ct.City);
            Console.ReadLine();
        }
    }
}
