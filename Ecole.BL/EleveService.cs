using MonEcole.DAL.DataAccess;
using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.BL
{
    class EleveService
    {
        public void Inscrire(Eleve eleve )
        {
            var dbctx = new EcoleDbContext();
            dbctx.Add(eleve);
            dbctx.SaveChanges();
        }
    }
}
