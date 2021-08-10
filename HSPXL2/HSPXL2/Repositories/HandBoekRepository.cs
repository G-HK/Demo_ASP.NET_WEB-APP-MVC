using HSPXL2.Data;
using HSPXL2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public class HandBoekRepository : IHandBoekRepository
    {
        public HSContext _DbContext;
        public HandBoekRepository(HSContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Creat(Handboek handboek)
        {
            handboek.CreationDate = DateTime.Now;
            _DbContext.Handboeks.Add(handboek);
            Save();
        }

        public void Delete(int ID)
        {
            _DbContext.Handboeks.Remove(Handboek(ID));
            Save();
        }

        public Handboek Handboek(int ID)
        {
            return _DbContext.Handboeks.Where(x => x.HandboekID == ID).FirstOrDefault();
        }

       // public  IQueryable<Handboek> Handboeks() =>_DbContext.Handboeks;
        public void Update(Handboek handboek)
        {
            _DbContext.Handboeks.Update(handboek);
            Save();
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public async Task<IEnumerable<Handboek>> Handboeks()
        {
            return await _DbContext.Handboeks.ToListAsync();
        }
    }
}
