using Demo.DAL.DataContext;
using Demo.DAL.Inteface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            ApiUsers = new ApiUserRepository(_context);
            Books = new BooksRepository(_context);
            User = new UsersRepository(_context);
            Employees = new EmployeesRepository(_context);
            Departments = new DepartmentsRepository(_context);
        }

        public IApiUsers ApiUsers { get; private set; }

        public IBooks Books { get; private set; }

        public IUser User { get; private set; }

        public IEmployees Employees { get; private set; }
        public IDepartments Departments { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
