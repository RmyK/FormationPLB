using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataAccess
{
    public class EcoleDbContext : DbContext
    {
        static string connectionString = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                if(connectionString ==null)
                {
                    var config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();
                    connectionString = config["ConnectionStrings:EcoleDbContext"];
                }
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public virtual DbSet<Administratif> Administratifs { get; set; } 
        public virtual DbSet<Ecole> Ecoles { get; set; } 
        public virtual DbSet<Eleve> Eleves { get; set; } 
        public virtual DbSet<Fonction> Fonctions { get; set; } 
        public virtual DbSet<Matiere> Matieres { get; set; }
        public virtual DbSet<Professeur> Professeurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //exemple de relation de table sans attribut
            //modelBuilder.Entity<Professeur>().HasOne<Matiere>();
            //modelBuilder.Entity<Professeur>().HasMany<Matiere>();


            // Data seed
            modelBuilder.Entity<Ecole>().HasData(
                new Ecole() { Id = 1, Nom = "St Exupéry" });
            modelBuilder.Entity<Matiere>().HasData(
                new Matiere() { Id = 1, Coefficient = 8, Libelle = "Mathematique" },
                new Matiere() { Id = 2, Coefficient = 9, Libelle = "Francais" },
                new Matiere() { Id = 3, Coefficient = 2, Libelle = "Sport" },
                new Matiere() { Id = 4, Coefficient = 7, Libelle = "Science" }
            );

            modelBuilder.Entity<Fonction>().HasData(
                new Fonction() { Id = 1, Libelle = "Secretaire", Service = "Administration" },
                new Fonction() { Id = 2, Libelle = "Educateur", Service = "Equipe pedagogique" },
                new Fonction() { Id = 3, Libelle = "Directeur", Service = "Administration" },
                new Fonction() { Id = 4, Libelle = "CPE", Service = "Equipe pedagogique" }
                );

            modelBuilder.Entity<Eleve>().HasData(
                new Eleve() { Id = 1, Nom = "Oumal", Prenom = "Fabien", Moyenne = 12, DateNaissance = new DateTime(2012, 9, 14), EcoleId = 1 },
                new Eleve() { Id = 2, Nom = "DePoheur", Prenom = "Agathe", Moyenne = 15, DateNaissance = new DateTime(2009, 2, 4), EcoleId = 1 }
                );
            modelBuilder.Entity<Professeur>().HasData(
                new Professeur() { Id = 3, Nom = "Erie", Prenom = "Yann", MatiereId = 4, DateNaissance = new DateTime(1984, 4, 17), EcoleId = 1 },
                new Professeur() { Id = 4, Nom = "Mobil", Prenom = "Otto", MatiereId = 3, DateNaissance = new DateTime(1978, 3, 22), EcoleId = 1 }
                );
            modelBuilder.Entity<Administratif>().HasData(
                new Administratif() { Id = 5, Nom = "Sion", Prenom = "Eva", FonctionId = 3, DateNaissance = new DateTime(1989, 11, 19), EcoleId = 1 }
                );
        }
    }
}
