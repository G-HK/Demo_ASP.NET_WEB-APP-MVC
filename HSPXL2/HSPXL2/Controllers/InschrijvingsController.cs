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
using System.Collections;
using Microsoft.AspNetCore.Authorization;
using HSPXL2.Models;
using AutoMapper;

namespace HSPXL2.Controllers
{
    [Authorize(Roles = "Admin")]

    public class InschrijvingsController : Controller
    {
        private readonly IInschrijvingRepository _inschrijvingRepository;
        private readonly IStudentRepository _studentRepo;
        private readonly ICursusRepository _cursusRepository;
        private readonly IMapper _mapper;

        public InschrijvingsController(IMapper mapper , ICursusRepository cursusRepository, IInschrijvingRepository inschrijvingRepository, IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
            _inschrijvingRepository = inschrijvingRepository;
            _cursusRepository = cursusRepository;
            _mapper = mapper;

        }

        [AllowAnonymous]
        // GET: Inschrijvings
        public IActionResult Index()
        {
            return View(_inschrijvingRepository.Inschrijvings());
        }

        [AllowAnonymous]
        // GET: Inschrijvings/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            var inschrijving = await _inschrijvingRepository.Inschrijving((int)id);
            if (inschrijving == null)
            {
                return NotFound();
            }

            return View(inschrijving);
        }

        // GET: Inschrijvings/Create
        public IActionResult Create()
        {
           
            ViewBag.CursusID = new SelectList(_cursusRepository.Cursussen(), "CursusID", "CursusName");
            ViewBag.StudentID = new SelectList(_studentRepo.Students()  , "StudentID", "Naam");

            return View();
        }

        // POST: Inschrijvings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("StudentID,CursusID")] Inschrijving inschrijving)
        {
            if (ModelState.IsValid)
            {
                _inschrijvingRepository.Creat(inschrijving);
                return RedirectToAction(nameof(Index));
            }
            return View(inschrijving);
        }

        // GET: Inschrijvings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inschrijving inschrijving = await _inschrijvingRepository.Inschrijving((int)id);

            InschrijvingDto inschrijvingDto = _mapper.Map<InschrijvingDto>(inschrijving);
            
            inschrijvingDto.CursusList = new SelectList(_cursusRepository.Cursussen(), "CursusID", "CursusName");
            inschrijvingDto.StudentList = new SelectList(_studentRepo.Students(), "StudentID", "Naam");

            if (inschrijving == null)
            {
                return NotFound();
            }
            return View(inschrijvingDto);
        }

        // POST: Inschrijvings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("InschrijvingID,StudentID,CursusID")] InschrijvingDto inschrijving)
        {
            

            if (ModelState.IsValid)
            {
                try
                {

                    Inschrijving inschrijving1 = _mapper.Map<Inschrijving>(inschrijving);
                    _inschrijvingRepository.Update(inschrijving1);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InschrijvingExists(inschrijving.InschrijvingID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw new ArgumentException("Parameter cannot be null", nameof(inschrijving));
                    }
                }
                
                return RedirectToAction(nameof(Index));
            }
            return View(inschrijving);
        }

        // GET: Inschrijvings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inschrijving = await _inschrijvingRepository.Inschrijving((int)id);
            if (inschrijving == null)
            {
                return NotFound();
            }

            return View(inschrijving);
        }

        // POST: Inschrijvings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _inschrijvingRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool InschrijvingExists(int id)
        {
            return _inschrijvingRepository.Inschrijving(id) == null ? false : true; 
        }
    }
}
