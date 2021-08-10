using HSPXL2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public interface ICursusRepository
    {
        IQueryable<Cursus> Cursussen();
        List<Cursus> StudentCursus(long [] id);

        Cursus Cursus(long ID);
        void Creat(Cursus cursus);
        void Update(Cursus cursus);
        void Delete(long ID);

        void Save();
    }
}
