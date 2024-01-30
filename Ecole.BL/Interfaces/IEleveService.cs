using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.BL.Interfaces
{
    public interface IEleveService
    {
        void Create(Eleve eleve);
        void Update(Eleve eleve);
        Eleve GetById(int id);
        List<Eleve> GetAll();
        void Delete(int id);
    }
}
