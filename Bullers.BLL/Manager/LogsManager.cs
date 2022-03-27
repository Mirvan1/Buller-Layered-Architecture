using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bullers.DAL.Abstract;
using Bullers.Interface;

namespace Bullers.BLL.Manager
{
    public class LogsManager : ILogsService
    {
        ILogsDAL _log;

        public LogsManager(ILogsDAL log)
        {
            _log = log;
        }

        public int CountProductViews(int ProductID)
        {
          return  _log.CountProductViews(ProductID);
        }
    }
}
