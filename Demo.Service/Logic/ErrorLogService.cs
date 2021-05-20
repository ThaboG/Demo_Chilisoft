using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Service.Logic
{
    public class ErrorLogService
    {
        public void Log(string Message)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.ErrorLog.Log(Message);
            }
        }
        public void Log(Exception exception)
        {
            Log(exception.Message);
        }
    }
}
