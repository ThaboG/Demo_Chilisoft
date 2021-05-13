using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Service.Logic
{
    public class DepartmentsService
    {
        public List<DAL.Entities.Departments> GetAll()
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.Departments.GetAll().ToList();
            }
        }

        public DAL.Entities.Departments Get(Guid id)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.Departments.Get(id);
            }
        }

        public bool Update(Departments departments)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.Departments.Update(departments);
                return uow.Complete() > 0;
            }
        }

        public bool Add(Departments departments)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.Departments.Add(departments);
                return uow.Complete() > 0;
            }
        }
    }
}
