using IMyWindowsFormsApp.Data.DB;
using IMyWindowsFormsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T>
    {
        private readonly IDbContext _dbContext;
        public BaseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Add(T model)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual int IndexOf(T model)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T model)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T model, int index)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
