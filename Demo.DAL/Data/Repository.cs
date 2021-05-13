using Demo.DAL.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data
{
   public class Repository<T> : IRepository<T> where T : class, IDataModel
    {
        protected readonly DbContext context;
        public Repository(DbContext context)
        {
            this.context = context;
        }
        public virtual void Add(T Item)
        {
            context.Set<T>().Add(Item);
        }

        public virtual void AddRange(IEnumerable<T> Items)
        {
            context.Set<T>().AddRange(Items);
        }

        public virtual void Update(T Item)
        {
            context.Set<T>().Update(Item);
        }
        public virtual void UpdateRange(IEnumerable<T> Items)
        {
            context.Set<T>().UpdateRange(Items);
        }
        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public virtual T Get(Guid ID)
        {
            return context.Set<T>().Find(ID);
        }

        public virtual async Task<T> GetAsyc(Guid ID)
        {
            return await context.Set<T>().FindAsync(ID);
        }

        public virtual IEnumerable<T> GetRange(int PageNumber, int PageSize)
        {
            return context.Set<T>().Skip(((PageNumber - 1) * PageSize)).Take(PageSize);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public virtual void Remove(T Item)
        {
            context.Set<T>().Remove(Item);
        }

        public virtual void RemoveRange(IEnumerable<T> Items)
        {
            context.Set<T>().RemoveRange(Items);
        }

        public virtual bool Any(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Any(predicate);
        }

        public virtual async Task<bool> AnyAsyc(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().AnyAsync(predicate);
        }
        public virtual void AddUpdateRange(IEnumerable<T> Items)
        {
            List<T> AddList = new List<T>();
            List<T> UpdateList = new List<T>();
            Items.ToList().ForEach(item =>
            {
                if (Any(p => p.ID == item.ID))
                {
                    if (!UpdateList.Any(p => p.ID == item.ID))
                    {
                        UpdateList.Add(item);
                    }
                }
                else
                {
                    if (!AddList.Any(p => p.ID == item.ID))
                    {
                        AddList.Add(item);
                    }
                }
            });
            if (AddList.Any())
            {
                AddRange(AddList);
            }
            if (UpdateList.Any())
            {
                UpdateRange(UpdateList);
            }
        }
    }
}
