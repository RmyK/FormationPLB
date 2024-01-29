using MonEcole.DAL.DataAccess;
using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.BL
{
    class ProfesseurService
    {
        public void Embaucher(Professeur prof)
        {
            using var dbctx = new EcoleDbContext();
            dbctx.Add(prof);
            dbctx.SaveChanges();
        }

    }
}
