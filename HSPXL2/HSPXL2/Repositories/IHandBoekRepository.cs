using HSPXL2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Repositories
{
    public interface IHandBoekRepository
    {
        Task<IEnumerable<Handboek>> Handboeks();

        Handboek Handboek (int ID);
        void Creat(Handboek handboek);
        void Update(Handboek handboek);
        void Delete(int ID);

        void Save();
    }
}
