using HSPXL2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students();
        IQueryable<Student> StudentsByName(string name);

        Student Student(long ID);

        void Creat(Student student);
        void Update(Student student);
        void Delete(long ID);
        void Save();
    }
}
