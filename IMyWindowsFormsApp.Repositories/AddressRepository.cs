using IMyWindowsFormsApp.Data.DB;
using IMyWindowsFormsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp.Repositories
{
    internal class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly IDbContext _dbContext;

        public AddressRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override void Add(Address model)
        {
            _dbContext.Addresses.Add(model);
        }

        public override Address Get(Guid id)
        {
            return _dbContext.Addresses.FirstOrDefault(x => x.StudentId == id);
        }

        public override void Remove(Address model)
        {
            _dbContext.Addresses.Remove(model);
        }

        public override void Update(Address model)
        {
            Address temp = _dbContext.Addresses.Where(x => x.StudentId == model.StudentId).FirstOrDefault();
            _dbContext.Addresses.Remove(temp);
            _dbContext.Addresses.Add(model);
        }
    }
}
