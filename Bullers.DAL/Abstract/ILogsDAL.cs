using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullers.DAL.Abstract
{
   public interface ILogsDAL
    {
        int CountProductViews(int ProductID);
    }
}
