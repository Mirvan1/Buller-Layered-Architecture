using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;

namespace Bullers.DAL.Concrete.EF
{
    public class EFLogsDAL : ILogsDAL
    {
        Context c = new Context();
        public int CountProductViews(int id)
        {
            return c.ProductLogs.Where(x => x.ProductID == id && x.Info.Equals("OnActionExecuted")).Count();
        }
    }
}
