using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Service.Logic
{
    public class ApiService
    {
        public static bool Login(string Username, string Password)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.ApiUsers.IsUserValid(Username, Password);
            }
        }
    }
}
