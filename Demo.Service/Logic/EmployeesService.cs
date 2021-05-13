using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Service.Logic
{
    public class EmployeesService
    {
        public List<DAL.Entities.Employees> GetAll()
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.Employees.GetAll().ToList();
            }
        }

        public bool Add(Employees books)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.Employees.Add(books);
                return uow.Complete() > 0;
            }
        }

        public DAL.Entities.Employees Get(Guid id)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.Employees.Get(id);
            }
        }

        public bool Update(Employees books)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.Employees.Update(books);
                return uow.Complete() > 0;
            }
        }

    }
}
