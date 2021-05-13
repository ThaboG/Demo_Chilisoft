using Demo.DAL.DataContext;
using Demo.DAL.Entities;
using Demo.DAL.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Data
{
    public class DepartmentsRepository : Repository<Departments>, IDepartments
    {
        public DepartmentsRepository(DbContext context) : base(context)
        {

        }

        public DatabaseContext _context
        {
            get => context as DatabaseContext;
        }
    }
}
