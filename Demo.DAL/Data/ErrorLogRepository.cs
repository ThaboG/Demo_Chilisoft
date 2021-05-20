using Demo.DAL.DataContext;
using Demo.DAL.Entities;
using Demo.DAL.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Data
{
    public class ErrorLogRepository : Repository<ErrorLog>, IErrorLog
    {
        public ErrorLogRepository(DbContext context) : base(context)
        {

        }

        public void Log(string Message)
        {
            Add(new ErrorLog()
            {
                ID = Guid.NewGuid(),
                Message = Message,
                CreateDateTime = DateTimeOffset.Now,
                ModifiedDate = null,
                IsDeleted = false,
                SyncClientID = Guid.NewGuid(),
                SyncTime = DateTimeOffset.Now
            });
        }
        public DatabaseContext _context
        {
            get => context as DatabaseContext;
        }
    }
}
