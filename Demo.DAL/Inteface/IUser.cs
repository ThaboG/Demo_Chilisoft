using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Inteface
{
    public interface IUser:IRepository<Entities.Users>
    {
        bool IsUserActive(string Username, string Password);
        bool IsUserValid(string Username, string Password);
        Entities.Users Login(string Username, string Password);
    }
}
