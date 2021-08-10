using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSPXL2.Data;
using HSPXL2.Entities;
using HSPXL2.Repositories;
using HSPXL2.Models;
using Microsoft.AspNetCore.Authorization;

namespace HSPXL2.Controllers
{
    [Authorize(Roles ="Admin")]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepo;
        private readonly ICursusRepository _cursusRepository;

        public StudentsController(HSContext context, IStudentRepository studentRepo, ICursusRepository cursusRepository)
        {
            _studentRepo = studentRepo;
            _cursusRepository = cursusRepository;
        }
        
      
        [AllowAnonymous]
        // GET: Students
        public IActionResult Index(string name = null)
        {
            dynamic students =  null;

            if (name != null)
            {
                students = _studentRepo.StudentsByName(name);
            }
            else
            {
                students = _studentRepo.Students();
            }

            List<StudentIndex> stud = new List<StudentIndex>();

            foreach (Student s in students)
            {

                StudentIndex std = new StudentIndex
                {
                    StudentID = s.StudentID,
                    Email = s.Email,
                    Naam = s.Naam,
                    CreationDate = s.CreationDate,
                    Cursus = _cursusRepository.StudentCursus( s.Inschrijvings.Where(x=>x.StudentID == s.StudentID).Select(x=>x.CursusID).ToArray())
                };

                stud.Add(std);
            }
            return View(stud);
        }

        [Authorize(Roles = "Admin,Student,Teacher")]
        // GET: Students/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentRepo.Student((long)id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Naam,Voornaam,Email,Psw")] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepo.Creat(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public IActionResult Edit(long? id)
        {
            var student = _studentRepo.Student((long)id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("StudentID,Naam,Voornaam,Email,Psw")] Student student)
        {
     


            if (ModelState.IsValid)
            {
                try
                {
                    _studentRepo.Update(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentRepo.Student((long)id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            _studentRepo.Delete((long)id);
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(long id)
        {
            return _studentRepo.Student(id) == null ? false : true;
        }
    }
}
