using Demo.DAL.DataContext;
using Demo.DAL.Entities;
using Demo.DAL.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Data
{
    public class EmployeesRepository : Repository<Employees>, IEmployees
    {
        public EmployeesRepository(DbContext context) : base(context)
        {

        }

        public override IEnumerable<Employees> GetAll()
        {
            return _context.Employees.Include(p => p.Department);
        }

        public DatabaseContext _context
        {
            get => context as DatabaseContext;
        }
    }
}
