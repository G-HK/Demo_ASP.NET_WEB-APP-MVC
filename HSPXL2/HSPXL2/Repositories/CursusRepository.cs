using HSPXL2.Data;
using HSPXL2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public class CursusRepository : ICursusRepository
    {
        public HSContext _DbContext;
        public CursusRepository(HSContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Creat(Cursus cursus)
        {
            _DbContext.Cursus.Add(cursus);
            Save();
        }

        public Cursus Cursus(long ID)
        {
           return _DbContext.Cursus.Where(x => x.CursusID == ID).FirstOrDefault();
        }

        public IQueryable<Cursus> Cursussen() => _DbContext.Cursus;
        

        public void Delete(long ID)
        {
            _DbContext.Cursus.Remove(Cursus(ID));
            Save();
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public List<Cursus> StudentCursus(long[] id)
        {
            List<Cursus> cursusList = new List<Cursus>();
            foreach (long idc in id)
            {
                cursusList.Add(Cursus(idc));
            }

            return cursusList;
        }

        public void Update(Cursus cursus)
        {
            _DbContext.Cursus.Update(cursus);
            Save();
        }
    }
}
