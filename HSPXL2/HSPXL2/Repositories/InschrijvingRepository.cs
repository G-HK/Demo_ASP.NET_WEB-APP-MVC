using HSPXL2.Data;
using HSPXL2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public class InschrijvingRepository : IInschrijvingRepository
    {
        public HSContext _DbContext;
        public InschrijvingRepository(HSContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Creat(Inschrijving inschrijving)
        {
            _DbContext.Inschrijvings.Add(inschrijving);
            Save();
        }

        public async void Delete(int ID)
        {
            _DbContext.Inschrijvings.Remove(await Inschrijving(ID));
            Save();
        }

        public async Task<Inschrijving> Inschrijving(int ID)
        {
            return await _DbContext.Inschrijvings.Include(i => i.Cursus).Include(i => i.Student).FirstOrDefaultAsync(m => m.InschrijvingID == ID);
        }

        public IQueryable<Inschrijving> Inschrijvings() => _DbContext.Inschrijvings.Include(i => i.Cursus).Include(i => i.Student);

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public IQueryable<Inschrijving> StudentInschrijvings(long StudentID)
        {
            return _DbContext.Inschrijvings.Where(x => x.StudentID == StudentID);
        }

        public void Update(Inschrijving inschrijving)
        {
            _DbContext.Update(inschrijving);
            Save();
        }
    }
}
