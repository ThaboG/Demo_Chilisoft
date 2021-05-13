using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Inteface
{
    public interface IApiUsers
    {
        bool IsUserValid(string Username, string Password);
        bool IsUserActive(string Username, string Password);
        ApiUser Login(string Username, string Password);
    }
}
