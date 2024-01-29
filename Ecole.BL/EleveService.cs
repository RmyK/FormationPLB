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
        public void Create(Eleve eleve )
        {
            using var dbctx = new EcoleDbContext();
            dbctx.Add(eleve);
            dbctx.SaveChanges();
        }

        public void Update(Eleve eleve)
        {
            using var dbctx = new EcoleDbContext();
            dbctx.Update(eleve);
            dbctx.SaveChanges();
        }

        public Eleve GetById(int id)
        {
            using var dbctx = new EcoleDbContext();
            return dbctx.Eleves.Find(id);
        }

        public void Delete(int id)
        {
            using var dbctx = new EcoleDbContext();
            var eleve = dbctx.Eleves.Find(id);
            dbctx.Eleves.Remove(eleve);
            dbctx.SaveChanges();
        }
    }
}
