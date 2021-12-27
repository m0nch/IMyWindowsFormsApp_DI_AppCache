using IMyWindowsFormsApp.Data.DB;
using IMyWindowsFormsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp.Repositories
{
    internal class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly IDbContext _dbContext;
        public StudentRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override void Add(Student model)
        {
            _dbContext.Students.Add(model);
        }

        public override Student Get(Guid id)
        {
            return _dbContext.Students.FirstOrDefault(x => x.Id == id);
        }

        public Address GetAddress(Guid id)
        {
            throw new NotImplementedException();
        }

        public override List<Student> GetAll()
        {
            return _dbContext.Students;
        }

        public List<Student> GetAllByTeacher(Guid id)
        {
            return _dbContext.Students.Where(x => x.TeacherId == id).ToList();
        }
        public override int IndexOf(Student model)
        {
            return _dbContext.Students.IndexOf(model);
        }

        public override void Remove(Student model)
        {
            _dbContext.Students.Remove(model);
        }

        public override void Update(Student model, int index)
        {
            _dbContext.Students[index] = model;
        }

        public override void Update(Student model)
        {
            Student temp = _dbContext.Students.Where(x => x.Id == model.Id).FirstOrDefault();
            _dbContext.Students.Remove(temp);
            _dbContext.Students.Add(model);
        }
    }
}
