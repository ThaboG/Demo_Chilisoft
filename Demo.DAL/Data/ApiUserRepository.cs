using Demo.DAL.DataContext;
using Demo.DAL.Entities;
using Demo.DAL.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.DAL.Data
{
    public class ApiUserRepository : Repository<ApiUser>, IApiUsers
    {
        public ApiUserRepository(DatabaseContext context) : base(context)
        {

        }
        public bool IsUserActive(string Username, string Password)
        {
            if (IsUserValid(Username, Password))
            {
                return ApiUserContext.ApiUsers.Any(p => p.Username == Username && p.Password == Password && !p.IsDeleted);
            }
            else
            {
                return false;
            }
        }

        public bool IsUserValid(string Username, string Password)
        {
            return ApiUserContext.ApiUsers.Any(p => p.Username == Username && p.Password == Password);
        }

        public ApiUser Login(string Username, string Password)
        {
            if (!IsUserValid(Username, Password))
            {
                throw new Exception("ApiUsername and access combination not valid");
            }
            else if (!IsUserActive(Username, Password))
            {
                throw new Exception("This ApiUser seem to have been diabled, Please contact support for assistance");
            }
            else
            {
                return ApiUserContext.ApiUsers.FirstOrDefault(p => p.Username == Username && p.Password == Password && !p.IsDeleted);
            }
        }

        public DatabaseContext ApiUserContext
        {
            get => context as DatabaseContext;
        }

    }
}