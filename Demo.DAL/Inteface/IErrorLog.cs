using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Inteface
{
    public interface IErrorLog : IRepository<Entities.ErrorLog>
    {
        void Log(string Message);
    }
}
