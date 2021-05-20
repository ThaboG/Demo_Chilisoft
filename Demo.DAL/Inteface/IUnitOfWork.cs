using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Inteface
{
    public interface IUnitOfWork : IDisposable
    {
        IApiUsers ApiUsers { get; }
        IBooks Books { get; }
        IEmployees Employees { get; }
        IUser User { get; }
        IDepartments Departments { get; }
        IErrorLog ErrorLog { get; }
        /// <summary>
        /// Save
        /// </summary>
        int Complete();
        /// <summary>
        /// SaveAsync
        /// </summary>
        /// <returns></returns>
        Task<int> CompleteAsync();
    }
}
