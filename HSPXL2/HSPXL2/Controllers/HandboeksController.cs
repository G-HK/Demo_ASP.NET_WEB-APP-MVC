using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSPXL2.Data;
using HSPXL2.Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using HSPXL2.Models;
using HSPXL2.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HSPXL2.Controllers
{
    [Authorize(Roles = "Admin,Teacher")]
    public class HandboeksController : Controller
    {
        private readonly IHandBoekRepository _handBoekRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public HandboeksController(IHandBoekRepository handBoekRepository, UserManager<IdentityUser> userManager)
        {
            _handBoekRepository = handBoekRepository;
            _userManager = userManager;
        }
        [AllowAnonymous]
        // GET: Handboeks
        public async Task<IActionResult> Index()
        {
            return View(await _handBoekRepository.Handboeks());
        }

        // GET: Handboeks/Details/5
        public IActionResult Details(int? id)
        {
            var handboek =  _handBoekRepository.Handboek((int)id);

            return View(handboek);
        }

        // GET: Handboeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Handboeks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,UitgiftDatum,Afbeelding")] HandboekDto handboek, List<IFormFile> Afbeelding, string KostPrijs)
        {
            if (ModelState.IsValid)
            {


                foreach (var item in Afbeelding)
                {
                    if (item.Length > 0)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await item.CopyToAsync(stream);
                            handboek.Afbeelding = stream.ToArray();
                        }
                    }
                }

                Handboek Hb = new Handboek
                {
                    Title = handboek.Title,
                    KostPrijs = Convert.ToDecimal(KostPrijs.Replace(".", ",")),
                    UitgiftDatum = handboek.UitgiftDatum,
                    Afbeelding = Convert.ToBase64String(handboek.Afbeelding),
                };


                //repo
                _handBoekRepository.Creat(Hb);

                return RedirectToAction(nameof(Index));
            }
            return View(handboek);
        }

        // GET: Handboeks/Edit/5
        public IActionResult Edit(int? id)
        {

            var handboek = _handBoekRepository.Handboek((int)id);
            HandboekDto HD = new HandboekDto
            {
                HandBoekID = handboek.HandboekID,
                KostPrijs  = handboek.KostPrijs,
                Title = handboek.Title,
                UitgiftDatum = handboek.UitgiftDatum
            };

            ViewBag.Image = handboek.Afbeelding;
            return View(HD);
        }

        // POST: Handboeks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("HandBoekID,Title,UitgiftDatum")] HandboekDto handboek, List<IFormFile> Afbeelding, string KostPrijs)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var item in Afbeelding)
                    {
                        if (item.Length > 0)
                        {
                            using (var stream = new MemoryStream())
                            {
                                await item.CopyToAsync(stream);
                                handboek.Afbeelding = stream.ToArray();
                            }
                        }
                    }


                    Handboek HD = new Handboek
                    {
                        HandboekID = handboek.HandBoekID,
                        Title = handboek.Title,
                        KostPrijs = Convert.ToDecimal(KostPrijs.Replace(".", ",")),
                        UitgiftDatum = handboek.UitgiftDatum,
                        Afbeelding = Convert.ToBase64String(handboek.Afbeelding),
                    }; 

                    _handBoekRepository.Update(HD);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HandboekExists(handboek.HandBoekID))
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
            return View(handboek);
        }

        // GET: Handboeks/Delete/5
        public IActionResult Delete(int? id)
        {
            var handboek = _handBoekRepository.Handboek((int)id);

            if (handboek == null)
            {
                return RedirectToAction("Index","Home");
            }

            return View(handboek);
        }

        // POST: Handboeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int HandboekID)
        {
            var handboek = _handBoekRepository.Handboek((int)HandboekID);

            _handBoekRepository.Delete((int)HandboekID);


            return RedirectToAction(nameof(Index));
        }

        private bool HandboekExists(int id)
        {
            return _handBoekRepository.Handboek(id) == null ? false : true; 
        }
    }
}
