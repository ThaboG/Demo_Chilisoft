using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Service.Logic
{
    public class BooksService
    {
        public IEnumerable<DAL.Entities.Books> GetAll()
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.Books.GetAll();
            }
        }

        public bool Add(Books books)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.Books.Add(books);
                return uow.Complete() > 0;
            }
        }

        public DAL.Entities.Books Get(Guid id)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                return uow.Books.Get(id);
            }
        }

        public bool Update(Books books)
        {
            using (DAL.Inteface.IUnitOfWork uow = new DAL.Data.UnitOfWork(new DAL.DataContext.DatabaseContext(DAL.DataContext.DatabaseContext.ops.dbOptions)))
            {
                uow.Books.Update(books);
                return uow.Complete() > 0;
            }
        }

    }
}
