using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql.BusinessEntities
{
    interface IBaseBusinessEntity
    {

    }
    class BaseBusinessEntity :IBaseBusinessEntity
    {

        public string conn;
        public LinqToSql.DataClassesDataContext db;
        public BaseBusinessEntity()
        {
            conn = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.NorthwindConnectionString"].ToString();
            db = new DataClassesDataContext(conn);
        }  
    }
}
