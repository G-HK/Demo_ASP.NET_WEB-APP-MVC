using HSPXL2.Data;
using HSPXL2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public HSContext _DbContext;
        public StudentRepository(HSContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Creat(Student student)
        {
            student.CreationDate = DateTime.Now;
            _DbContext.Students.Add(student);
            Save();
        }

        public void Delete(long ID)
        {
            _DbContext.Students.Remove(Student(ID));
            Save();
        }

        public void Save() => _DbContext.SaveChanges();

        public Student Student(long ID)
        {
            return _DbContext.Students.Where(x => x.StudentID == ID).First();
        }

        public IQueryable<Student> Students()
        {
            return _DbContext.Students.Include(i => i.Inschrijvings);
        }
            

        public IQueryable<Student> StudentsByName(string name) => _DbContext.Students.Where(x => x.Naam.Contains(name)).Include(i => i.Inschrijvings);

        public void Update(Student student)
        {
            //Student s = Student(student.StudentID);
            //s.Naam = student.Naam;
            //s.Email = student.Email;
            //s.Voornaam = student.Voornaam;
           
            _DbContext.Students.Update(student);
            Save();
        }
    }
}
