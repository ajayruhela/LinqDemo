using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BusinessEntities
{
    class Order_Detail : BaseBusinessEntity
    {
        public Order_Detail(): base()
        {

        }

        //public IEnumerable<LinqToSql.Order_Detail> getAllOrderDetails()
        //{
        //    IEnumerable<LinqToSql.Order_Detail> c = this.db.Order_Detail;
        //    return c;

        //}

        //public bool delOrder_Details(int oID,int prdID)
        //{
        //    LinqToSql.Order_Detail c = this.db.Order_Details.Where(k =>k.Order.OrderID == oID).Where(k=>k.Product.ProductID == prdID);
        //    db.Customers.DeleteOnSubmit(c);
        //    db.SubmitChanges();
        //    return true;

        //}
    }
}
