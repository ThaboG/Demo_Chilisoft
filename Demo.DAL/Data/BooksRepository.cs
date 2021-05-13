using Demo.DAL.DataContext;
using Demo.DAL.Entities;
using Demo.DAL.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Data
{
    public class BooksRepository : Repository<Books>, IBooks
    {
        public BooksRepository(DbContext context) : base(context)
        {

        }

        public DatabaseContext _context
        {
            get => context as DatabaseContext;
        }
    }
}
