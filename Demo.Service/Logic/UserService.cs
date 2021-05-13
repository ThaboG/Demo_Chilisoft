using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Service.Logic
{
    public class UserService
    {
        public DAL.Entities.Users Login(string Userame, String Password)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.User.Login(Userame, Password);
            }
        }
    }
}
