using HSPXL2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public interface IInschrijvingRepository
    {
        IQueryable<Inschrijving> Inschrijvings();
        IQueryable<Inschrijving> StudentInschrijvings(long StudentID);

        Task<Inschrijving> Inschrijving(int ID);
        void Creat(Inschrijving inschrijving);
        void Update(Inschrijving inschrijving);
        void Delete(int ID);
        void Save();
    }
}
