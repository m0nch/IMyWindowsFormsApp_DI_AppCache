using IMyWindowsFormsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp.Repositories
{
    public interface IBaseRepository<T>
    {
        void Add(T model);
        void Remove(T model);
        void Update(T model, int index);
        void Update(T model);
        T Get(Guid id);
        List<T> GetAll();
        int IndexOf(T model);
    }
}
