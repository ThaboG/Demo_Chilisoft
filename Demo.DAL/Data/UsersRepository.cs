using Demo.DAL.DataContext;
using Demo.DAL.Entities;
using Demo.DAL.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.DAL.Data
{
    public class UsersRepository : Repository<Users>, IUser
    {
        public UsersRepository(DbContext context) : base(context)
        {

        }
        public bool IsUserActive(string Username, string Password)
        {
            if (IsUserValid(Username, Password))
            {
                return _context.Users.Any(p => p.Username == Username && p.Password == Password && !p.IsDeleted);
            }
            else
            {
                return false;
            }
        }

        public bool IsUserValid(string Username, string Password)
        {
            var user = _context.Users.Where(p => p.Username == Username && p.Password == Password).ToList();

            return user.Any() && user.FirstOrDefault().Password.CaseSensitiveCompare(Password);
        }

        public Users Login(string Username, string Password)
        {
            if (!IsUserValid(Username, Password))
            {
                throw new Exception("Username and access combination not valid");
            }
            else if (!IsUserActive(Username, Password))
            {
                throw new Exception("This user seem to have been diabled, Please contact support for assistance");
            }
            else
            {
                return _context.Users.Include(p => p.UserType)
                    .Include(p=>p.UserAdminRel).ThenInclude(p=>p.Admin)
                    .Include(p=>p.GeneralUserRel).ThenInclude(p=>p.GeneralUser)
                    .Include(p=>p.UserEmployeeRel).ThenInclude(p=>p.Employee)
                    .FirstOrDefault(p => p.Username == Username && p.Password == Password && !p.IsDeleted);
            }
        }
        public DatabaseContext _context
        {
            get => context as DatabaseContext;
        }

    }
}
