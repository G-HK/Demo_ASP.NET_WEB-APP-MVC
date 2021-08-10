using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HSPXL2.Data;
using HSPXL2.Entities;

namespace HSPXL2.Pages
{
    public class StudentRazerPageModel : PageModel
    {
        private readonly HSContext _context;

        public StudentRazerPageModel(HSContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
